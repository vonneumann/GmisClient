

Public Class frmCorAssureList
    Inherits frmBasic

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    Public Sub New(ByVal project_code As String, ByVal corporation_name As String, ByVal phrase As String)
        MyBase.New()
        InitializeComponent()
    End Sub
    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents btnNewCor As System.Windows.Forms.Button
    Friend WithEvents btnModifyCor As System.Windows.Forms.Button
    Friend WithEvents dgCorList As System.Windows.Forms.DataGrid
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCorAssureList))
        Me.btnNewCor = New System.Windows.Forms.Button()
        Me.btnModifyCor = New System.Windows.Forms.Button()
        Me.dgCorList = New System.Windows.Forms.DataGrid()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        CType(Me.dgCorList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(360, 152)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Visible = True
        '
        'btnNewCor
        '
        Me.btnNewCor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNewCor.Image = CType(resources.GetObject("btnNewCor.Image"), System.Drawing.Bitmap)
        Me.btnNewCor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewCor.ImageIndex = 13
        Me.btnNewCor.ImageList = Me.ImageListBasic
        Me.btnNewCor.Location = New System.Drawing.Point(102, 152)
        Me.btnNewCor.Name = "btnNewCor"
        Me.btnNewCor.Size = New System.Drawing.Size(77, 23)
        Me.btnNewCor.TabIndex = 2
        Me.btnNewCor.Text = "新 增(&N)"
        Me.btnNewCor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModifyCor
        '
        Me.btnModifyCor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModifyCor.Image = CType(resources.GetObject("btnModifyCor.Image"), System.Drawing.Bitmap)
        Me.btnModifyCor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyCor.ImageIndex = 14
        Me.btnModifyCor.ImageList = Me.ImageListBasic
        Me.btnModifyCor.Location = New System.Drawing.Point(188, 152)
        Me.btnModifyCor.Name = "btnModifyCor"
        Me.btnModifyCor.Size = New System.Drawing.Size(77, 23)
        Me.btnModifyCor.TabIndex = 3
        Me.btnModifyCor.Text = "修 改(&M)"
        Me.btnModifyCor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgCorList
        '
        Me.dgCorList.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dgCorList.CaptionVisible = False
        Me.dgCorList.DataMember = ""
        Me.dgCorList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCorList.Location = New System.Drawing.Point(8, 8)
        Me.dgCorList.Name = "dgCorList"
        Me.dgCorList.ReadOnly = True
        Me.dgCorList.Size = New System.Drawing.Size(432, 136)
        Me.dgCorList.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(274, 152)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Bitmap)
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopy.ImageIndex = 13
        Me.btnCopy.ImageList = Me.ImageListBasic
        Me.btnCopy.Location = New System.Drawing.Point(16, 152)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(77, 23)
        Me.btnCopy.TabIndex = 1
        Me.btnCopy.Text = "导 入(&I)"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCorAssureList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(450, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCopy, Me.btnDelete, Me.btnExit, Me.btnModifyCor, Me.btnNewCor, Me.dgCorList})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCorAssureList"
        Me.Text = "设置保证企业"
        CType(Me.dgCorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ProjectCode As String
    Private CorporationName As String
    Private phrase As String
    Private dsCorPro As DataSet
    Private bmCorAssure As BindingManagerBase
    Private style As DataGridTableStyle

    Private Sub CreateTableStyle()
        style = New DataGridTableStyle()
        style.MappingName = "TProjectCorporation"
        style.AllowSorting = False
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col1.MappingName = "corporation_code"
        col1.HeaderText = "企业编码 "
        col1.Width = 70
        col1.NullText = String.Empty
        col1.Alignment = HorizontalAlignment.Left
        style.GridColumnStyles.Add(col1)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "corporation_name"
        col3.HeaderText = " 保证企业名称  "
        col3.Width = 300
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Left
        style.GridColumnStyles.Add(col3)
    End Sub

    Public Overloads Sub Refresh(ByVal sender As Object, ByVal e As EventArgs)
        Refresh()
    End Sub

    Public Overloads Sub Refresh()
        dsCorPro = gWs.FetchProjectCorporation(ProjectCode, "%", "2", phrase)
        bmCorAssure = BindingContext(dsCorPro, "TProjectCorporation")
        dgCorList.DataMember = "TProjectCorporation"
        dgCorList.DataSource = dsCorPro
        btnModifyCor.Enabled = bmCorAssure.Count > 0
        btnDelete.Enabled = btnModifyCor.Enabled
        dgCorList.TableStyles.Clear()
        dgCorList.TableStyles.Add(style)
    End Sub

    Private Sub frmCorAssureList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        ProjectCode = MyBase.getProjectCode
        phrase = MyBase.getPhase(ProjectCode) & String.Empty
        CorporationName = MyBase.getCorporationName() & String.Empty

        CreateTableStyle()
        Refresh()
    End Sub

    Private Sub btnNewCor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCor.Click
        Dim oForm As frmCorAssure = New frmCorAssure(-1, ProjectCode, CorporationName, phrase)
        oForm.WindowState = FormWindowState.Normal
        oForm.StartPosition = FormStartPosition.CenterScreen
        oForm.Owner = Me
        oForm.Show()
    End Sub

    Private Sub btnModifyCor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyCor.Click
        Dim pos As Integer = dgCorList.CurrentRowIndex
        Dim CorCode As String = CStr(dgCorList.Item(pos, 0))
        Dim oForm As frmCorAssure = New frmCorAssure(pos, ProjectCode, CorporationName, phrase, CorCode)
        oForm.WindowState = FormWindowState.Normal
        oForm.StartPosition = FormStartPosition.CenterScreen
        oForm.Owner = Me
        oForm.Show()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not (SWDialogBox.MessageBox.Show("?1004", "") = DialogResult.Yes) Then
            Return
        End If

        Dim pos As Integer = dgCorList.CurrentRowIndex
        Dim CorCode As String = CStr(dgCorList.Item(pos, 0))
        Dim result As String = gWs.DeleteAntiAssureCompany(ProjectCode, CorCode)
        If result = "1" Then
            Refresh()
            SWDialogBox.MessageBox.Show("$DeleteSucceed")
        Else
            SWDialogBox.MessageBox.Show("*999", "删除失败", result, "")
        End If
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Dim frmCopy As FAntiAssureCompanys = New FAntiAssureCompanys(ProjectCode, phrase)
        frmCopy.AllowTransparency = False
        AddHandler frmCopy.CopySuccess, AddressOf Refresh
        frmCopy.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub


End Class
