
Public Class frmProjectCorpInfo
    Inherits System.Windows.Forms.Form

    Dim dt As DataTable


    Private corporation_code, ProjectCode, PhaseCode As String

    '
    'DoubleClick DataGrid to activate btn_ok.Click to select data
    '
    Private Sub DataGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dg_proj_corp.DoubleClick
        Me.btn_ok_Click(Nothing, Nothing)
    End Sub
    Private Sub FillDataGrid()
        Me.DataGridTableStyle()
        Dim ds As DataSet = VouchService.FetchProjectCorporation("%", Me.corporation_code, "1", "%")

        dt = ds.Tables("TProjectCorporation")
        Me.dg_proj_corp.DataSource = dt
    End Sub

    'design DataGrid display pattern
    Private Sub DataGridTableStyle()
        dg_proj_corp.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TProjectCorporation"

        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "project_code"
        col1.HeaderText = "项目编号"
        col1.Width = 70

        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "phase"
        col2.HeaderText = "阶段信息"
        col2.Width = 70
        col2.NullText = ""

        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "corporation_code"
        col3.HeaderText = "企业编码"
        col3.NullText = ""
        col3.Width = 70

        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "corporation_name"
        col4.HeaderText = "企业名称"
        col4.Width = 200
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4})
        dg_proj_corp.TableStyles.Add(dgts)
    End Sub

    'load the form to fill data for DataGrid
    Private Sub frmProjectCorpInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.FillDataGrid()
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '
    'press this button to select data
    '
    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        If dt.Rows.Count > 0 Then
            ProjectCode = Me.dg_proj_corp.Item(Me.dg_proj_corp.CurrentCell.RowNumber, 0)
            PhaseCode = Me.dg_proj_corp.Item(Me.dg_proj_corp.CurrentCell.RowNumber, 1)
        Else
            ProjectCode = ""
            PhaseCode = ""
        End If
        Me.Close()
    End Sub

    Public ReadOnly Property Phase_Code() As String
        Get
            Return PhaseCode
        End Get
    End Property
    Public ReadOnly Property Project_code() As String
        Get
            Return ProjectCode
        End Get
    End Property


    '
    'press this button to exit the form
    '
    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        ProjectCode = ""
        PhaseCode = ""
        Me.Close()
    End Sub
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    Public Sub New(ByVal Corp_code As String)
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        Me.corporation_code = Corp_code

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
    Friend WithEvents dg_proj_corp As System.Windows.Forms.DataGrid
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProjectCorpInfo))
        Me.dg_proj_corp = New System.Windows.Forms.DataGrid()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.dg_proj_corp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_proj_corp
        '
        Me.dg_proj_corp.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dg_proj_corp.CaptionVisible = False
        Me.dg_proj_corp.DataMember = ""
        Me.dg_proj_corp.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dg_proj_corp.Location = New System.Drawing.Point(8, 8)
        Me.dg_proj_corp.Name = "dg_proj_corp"
        Me.dg_proj_corp.ReadOnly = True
        Me.dg_proj_corp.Size = New System.Drawing.Size(536, 280)
        Me.dg_proj_corp.TabIndex = 0
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Bitmap)
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.ImageIndex = 0
        Me.btn_ok.ImageList = Me.ImageList1
        Me.btn_ok.Location = New System.Drawing.Point(192, 296)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(80, 24)
        Me.btn_ok.TabIndex = 1
        Me.btn_ok.Text = "确 定(&S)"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_exit
        '
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Bitmap)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.ImageIndex = 1
        Me.btn_exit.ImageList = Me.ImageList1
        Me.btn_exit.Location = New System.Drawing.Point(280, 296)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(80, 24)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "退 出(&X)"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmProjectCorpInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(552, 327)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_exit, Me.dg_proj_corp, Me.btn_ok})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectCorpInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "选择历史数据"
        CType(Me.dg_proj_corp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class
