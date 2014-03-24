Public Class FServiceTypeDialog
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents lblServiceType As System.Windows.Forms.Label
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FServiceTypeDialog))
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'cboServiceType
        '
        Me.cboServiceType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cboServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServiceType.Location = New System.Drawing.Point(88, 32)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(256, 20)
        Me.cboServiceType.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Bitmap)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.ImageIndex = 0
        Me.btnOK.ImageList = Me.ImageList1
        Me.btnOK.Location = New System.Drawing.Point(176, 64)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(77, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "确 定(&O)"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Bitmap)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 1
        Me.btnCancel.ImageList = Me.ImageList1
        Me.btnCancel.Location = New System.Drawing.Point(264, 64)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "取 消(&C)"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(8, 36)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(80, 16)
        Me.lblServiceType.TabIndex = 2
        Me.lblServiceType.Text = "目的业务品种"
        '
        'lblSource
        '
        Me.lblSource.Location = New System.Drawing.Point(8, 13)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(80, 16)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "来源业务品种"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(88, 8)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.ReadOnly = True
        Me.txtSource.Size = New System.Drawing.Size(256, 21)
        Me.txtSource.TabIndex = 1
        Me.txtSource.TabStop = False
        Me.txtSource.Text = ""
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FServiceTypeDialog
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(354, 95)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtSource, Me.lblSource, Me.lblServiceType, Me.btnCancel, Me.btnOK, Me.cboServiceType})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FServiceTypeDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "业务品种选择"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ServiceType As String

    Public Property SourceServiceType() As String
        Get
            Return txtSource.Text
        End Get
        Set(ByVal Value As String)
            txtSource.Text = Value
        End Set
    End Property

    Private Sub FServiceTypeDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsServiceType As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsServiceType.Tables(0)
        cboServiceType.ValueMember = "service_type"
        cboServiceType.DisplayMember = "service_type"

        ServiceType = Nothing
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        ServiceType = cboServiceType.SelectedValue
    End Sub
End Class
