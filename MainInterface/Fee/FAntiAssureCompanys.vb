Public Class FAntiAssureCompanys
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
    End Sub

    Public Sub New(ByVal project_code As String, ByVal phrase As String)
        Me.New()
        m_ProjectCode = project_code
        m_CorporationCode = project_code.Substring(0, 5)
        m_Phrase = phrase
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
    Friend WithEvents col_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents col_ProjectCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_phase As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_month As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents lvwCompanies As System.Windows.Forms.ListView
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lvwFinance As System.Windows.Forms.ListView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList
    Friend WithEvents txtQueryName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FAntiAssureCompanys))
        Me.btnCopy = New System.Windows.Forms.Button
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lvwCompanies = New System.Windows.Forms.ListView
        Me.col_Code = New System.Windows.Forms.ColumnHeader
        Me.col_name = New System.Windows.Forms.ColumnHeader
        Me.btnOK = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lvwFinance = New System.Windows.Forms.ListView
        Me.col_ProjectCode = New System.Windows.Forms.ColumnHeader
        Me.col_phase = New System.Windows.Forms.ColumnHeader
        Me.col_month = New System.Windows.Forms.ColumnHeader
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtQueryName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnQuery = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCopy
        '
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopy.ImageIndex = 0
        Me.btnCopy.ImageList = Me.ImageListBasic
        Me.btnCopy.Location = New System.Drawing.Point(186, 304)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(77, 23)
        Me.btnCopy.TabIndex = 0
        Me.btnCopy.Text = "导 入(&I)"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 1
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(282, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lvwCompanies)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 256)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "反担保企业列表"
        '
        'lvwCompanies
        '
        Me.lvwCompanies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Code, Me.col_name})
        Me.lvwCompanies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwCompanies.Location = New System.Drawing.Point(3, 17)
        Me.lvwCompanies.MultiSelect = False
        Me.lvwCompanies.Name = "lvwCompanies"
        Me.lvwCompanies.Size = New System.Drawing.Size(250, 236)
        Me.lvwCompanies.TabIndex = 3
        Me.lvwCompanies.View = System.Windows.Forms.View.Details
        '
        'col_Code
        '
        Me.col_Code.Text = "编码"
        Me.col_Code.Width = 70
        '
        'col_name
        '
        Me.col_name.Text = "企业名称"
        Me.col_name.Width = 170
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(272, 136)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(56, 40)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "选定一企业"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lvwFinance)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 288)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "选定的企业"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "该企业现有的财务数据"
        '
        'lvwFinance
        '
        Me.lvwFinance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwFinance.CheckBoxes = True
        Me.lvwFinance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_ProjectCode, Me.col_phase, Me.col_month})
        Me.lvwFinance.Location = New System.Drawing.Point(8, 112)
        Me.lvwFinance.MultiSelect = False
        Me.lvwFinance.Name = "lvwFinance"
        Me.lvwFinance.Size = New System.Drawing.Size(216, 168)
        Me.lvwFinance.TabIndex = 4
        Me.lvwFinance.View = System.Windows.Forms.View.Details
        '
        'col_ProjectCode
        '
        Me.col_ProjectCode.Text = "项目编码"
        Me.col_ProjectCode.Width = 85
        '
        'col_phase
        '
        Me.col_phase.Text = "阶  段"
        Me.col_phase.Width = 70
        '
        'col_month
        '
        Me.col_month.Text = "年月"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtName.Location = New System.Drawing.Point(64, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(160, 21)
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "名  称"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCode.Location = New System.Drawing.Point(64, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(160, 21)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "编  码"
        '
        'txtQueryName
        '
        Me.txtQueryName.Location = New System.Drawing.Point(64, 8)
        Me.txtQueryName.Name = "txtQueryName"
        Me.txtQueryName.Size = New System.Drawing.Size(128, 21)
        Me.txtQueryName.TabIndex = 7
        Me.txtQueryName.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "企业名称"
        '
        'btnQuery
        '
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 2
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(200, 7)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(80, 23)
        Me.btnQuery.TabIndex = 9
        Me.btnQuery.Text = "选择企业"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FAntiAssureCompanys
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(576, 333)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQueryName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCopy)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FAntiAssureCompanys"
        Me.Text = "导入反担保企业及财务数据"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_ProjectCode, m_Phrase, m_CorporationCode As String
    Private m_RaiseCheckChangedEvent As Boolean
    Public Event CopySuccess As EventHandler
    Private m_SystemTime As DateTime

    Private Sub FAntiAssureCompanys_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            m_SystemTime = gWs.GetSysTime
           
            AddHandler lvwFinance.ItemCheck, AddressOf lvwFinance_ItemCheck
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If lvwCompanies.SelectedItems.Count > 0 Then
            Dim changed As Boolean
            Dim item As ListViewItem = lvwCompanies.SelectedItems(0)
            changed = (txtCode.Text <> item.SubItems(0).Text) '选定企业已改变
            txtCode.Text = item.SubItems(0).Text
            txtName.Text = item.SubItems(1).Text
            If changed Then
                m_RaiseCheckChangedEvent = False
                lvwFinance.Items.Clear()
                Dim dsFinance As DataSet = gWs.GetCommonQueryInfo(String.Format("SELECT DISTINCT project_code,phase,month FROM corporation_account WHERE corporation_code='{0}'", txtCode.Text))
                Dim row As DataRow
                For Each row In dsFinance.Tables(0).Rows
                    lvwFinance.Items.Add(New ListViewItem(New String() {row("project_code"), row("phase"), row("month")}))
                Next
                dsFinance.Dispose()
                m_RaiseCheckChangedEvent = True
            End If
        End If
    End Sub

    Private Function ImportFinanceData() As Boolean
        '如选中要导入的财务数据，则导入
        If lvwFinance.CheckedIndices.Count = 0 Then
            Return True
        End If
        Dim fromProjectCode, fromPhrase, fromMonth As String
        Dim result As String
        Dim i As Int32
        Me.Cursor = Cursors.WaitCursor
        For i = 0 To lvwFinance.Items.Count - 1
            If lvwFinance.Items(i).Checked Then
                fromProjectCode = lvwFinance.Items(i).SubItems(0).Text
                fromPhrase = lvwFinance.Items(i).SubItems(1).Text
                fromMonth = lvwFinance.Items(i).SubItems(2).Text
                result = gWs.ImportFinanceData(txtCode.Text, fromProjectCode, fromPhrase, fromMonth, txtCode.Text, m_ProjectCode, m_Phrase, UserName, m_SystemTime, True)
                If result <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "复制财务数据出错", result, "")
                    Return False
                End If
            End If
        Next        'MessageBox.Show(String.Format("fromProjectCode：{3}{1}{1} fromPhrase：{0}{1}{1} fromMonth：{2}", fromPhrase, System.Environment.NewLine, fromMonth, fromProjectCode))
        Me.Cursor = Cursors.Default

        Return True
    End Function

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If txtCode.Text = String.Empty Then
            Return
        End If
        If Not (SWDialogBox.MessageBox.Show("!1002") = MsgBoxResult.Yes) Then
            Return
        End If

        '如没项目企业记录，则新增
        Dim dsProjectCorporation As DataSet = gWs.FetchProjectCorporation(m_ProjectCode, txtCode.Text, "2", "%")
        If dsProjectCorporation.Tables(0).Rows.Count = 0 Then
            Dim col As DataColumn
            Dim dsCorp As DataSet = gWs.GetcorporationInfo(txtCode.Text, "NULL")
            Dim newRow As DataRow = dsProjectCorporation.Tables(0).NewRow
            For Each col In dsCorp.Tables("corporation").Columns
                If dsProjectCorporation.Tables(0).Columns.IndexOf(col.ColumnName) >= 0 Then
                    newRow(col.ColumnName) = dsCorp.Tables("corporation").Rows(0)(col.ColumnName)
                End If
            Next
            With newRow
                .Item("project_code") = m_ProjectCode
                .Item("corporation_code") = txtCode.Text
                .Item("phase") = m_Phrase
                .Item("corporation_type") = "2"
                .Item("create_person") = UserName
                .Item("create_date") = m_SystemTime
                .Item("nationality") = "中国"
                .Item("attorney_nationality") = "中国"
            End With
            dsProjectCorporation.Tables(0).Rows.Add(newRow)
            Dim result As String = gWs.UpdateProjectCorporation(dsProjectCorporation)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存项目企业表失败", result, "")
                Return
            End If
        End If
        dsProjectCorporation.Dispose()

        If ImportFinanceData() Then
            SWDialogBox.MessageBox.Show("$OperateSucceed")
            RaiseEvent CopySuccess(Me, e.Empty)
        End If
    End Sub

    Private Sub lvwFinance_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        If Not m_RaiseCheckChangedEvent Then '致命的一击
            Return
        End If

        If e.CurrentValue = e.NewValue Then
            Return
        End If

        Dim item As ListViewItem = lvwFinance.Items(e.Index)
        Dim i As Int32
        For i = 0 To lvwFinance.Items.Count - 1
            '非当前更改项
            If lvwFinance.Items(i).Checked Then '已打上勾
                '如果阶段和年月相同
                m_RaiseCheckChangedEvent = False
                If lvwFinance.Items(i).SubItems(1).Text = item.SubItems(1).Text AndAlso _
                            lvwFinance.Items(i).SubItems(2).Text = item.SubItems(2).Text Then
                    If e.NewValue = CheckState.Checked Then
                        lvwFinance.Items(i).Checked = False
                    End If
                End If
                m_RaiseCheckChangedEvent = True
            End If
        Next
    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        lvwCompanies.Items.Clear()
        Dim name As String = IIf(txtQueryName.Text = String.Empty, "%", "%" & txtQueryName.Text & "%")
        'Dim dsCompany As DataSet = gWs.GetCommonQueryInfo("SELECT corporation_code,corporation_name FROM corporation WHERE corporation_type='2' AND corporation_name LIKE '" & name & "'")
        Dim dsCompany As DataSet = gWs.GetCommonQueryInfo("SELECT corporation_code,corporation_name FROM corporation WHERE corporation_name LIKE '" & name & "'")
        Dim row As DataRow
        For Each row In dsCompany.Tables(0).Rows
            lvwCompanies.Items.Add(New ListViewItem(New String() {row("corporation_code"), row("corporation_name")}))
        Next
        dsCompany.Dispose()
        txtCode.Text = String.Empty
        txtName.Text = String.Empty
    End Sub
End Class
