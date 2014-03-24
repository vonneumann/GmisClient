Public Class FCopyGuaranteeCheckRecord
    Inherits System.Windows.Forms.Form
    Private CorCode As String
    Private dsCheck As DataSet
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
    End Sub
    Public Sub New(ByVal _CorCode As String, ByVal _currentProjectCode As String)
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        CorCode = _CorCode
        CurrentProjectCode = _currentProjectCode
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
    Friend WithEvents dgShow As System.Windows.Forms.DataGrid
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgts As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FCopyGuaranteeCheckRecord))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgShow = New System.Windows.Forms.DataGrid()
        Me.dgts = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.dgShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Bitmap)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.ImageIndex = 0
        Me.btnOk.ImageList = Me.ImageList1
        Me.btnOk.Location = New System.Drawing.Point(120, 256)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(77, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "确 定(&O)"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 1
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(240, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgShow
        '
        Me.dgShow.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dgShow.CaptionVisible = False
        Me.dgShow.DataMember = ""
        Me.dgShow.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgShow.Location = New System.Drawing.Point(8, 8)
        Me.dgShow.Name = "dgShow"
        Me.dgShow.ReadOnly = True
        Me.dgShow.Size = New System.Drawing.Size(440, 240)
        Me.dgShow.TabIndex = 0
        Me.dgShow.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgts})
        '
        'dgts
        '
        Me.dgts.DataGrid = Me.dgShow
        Me.dgts.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4})
        Me.dgts.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgts.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn1.MappingName = "project_code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 90
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "阶   段"
        Me.DataGridTextBoxColumn2.MappingName = "phase"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "年  月"
        Me.DataGridTextBoxColumn4.MappingName = "month"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 80
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FCopyGuaranteeCheckRecord
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(456, 285)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnOk, Me.dgShow})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FCopyGuaranteeCheckRecord"
        Me.Text = "选择历史数据"
        CType(Me.dgShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private _ProjectCode, _Month, _Phase As String
    Private CurrentProjectCode As String
    Private Sub FCopyGuaranteeCheckRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSQL As String = "SELECT DISTINCT project_code,phase,month" & _
                                " FROM dbo.corporation_account" & _
                                " WHERE corporation_code='" & CorCode.Trim & "' AND project_code<>'" & CurrentProjectCode & "'"
        dsCheck = gWs.GetCommonQueryInfo(strSQL)
        dgShow.SetDataBinding(dsCheck, "Table")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        _ProjectCode = String.Empty
        _Month = String.Empty
        _Phase = String.Empty
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If dgShow.CurrentRowIndex < 0 Then
            _ProjectCode = String.Empty
            _Month = String.Empty
        Else
            _ProjectCode = dgShow.Item(dgShow.CurrentRowIndex, 0)
            _Phase = dgShow.Item(dgShow.CurrentRowIndex, 1)
            _Month = dgShow.Item(dgShow.CurrentRowIndex, 2)
        End If
        Me.Close()
    End Sub

    Public ReadOnly Property ProjectCode() As String
        Get
            Return _ProjectCode
        End Get
    End Property

    Public ReadOnly Property Month() As String
        Get
            Return _Month
        End Get
    End Property
    Public ReadOnly Property Phase() As String
        Get
            Return _Phase
        End Get
    End Property
End Class
