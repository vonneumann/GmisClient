Public Class FWaitingProcess
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    Public Sub New(ByVal str As String)
        Me.new()
        Me.labText.Text = str
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
    Friend WithEvents btnSucceed As System.Windows.Forms.Button
    Friend WithEvents labText As System.Windows.Forms.Label
    Friend WithEvents picBox As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FWaitingProcess))
        Me.labText = New System.Windows.Forms.Label()
        Me.btnSucceed = New System.Windows.Forms.Button()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'labText
        '
        Me.labText.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.labText.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labText.ForeColor = System.Drawing.Color.Blue
        Me.labText.Location = New System.Drawing.Point(28, 16)
        Me.labText.Name = "labText"
        Me.labText.Size = New System.Drawing.Size(336, 23)
        Me.labText.TabIndex = 0
        Me.labText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSucceed
        '
        Me.btnSucceed.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSucceed.Location = New System.Drawing.Point(159, 112)
        Me.btnSucceed.Name = "btnSucceed"
        Me.btnSucceed.TabIndex = 1
        Me.btnSucceed.Text = "完成(&S)"
        '
        'picBox
        '
        Me.picBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.picBox.Location = New System.Drawing.Point(153, 72)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(86, 17)
        Me.picBox.TabIndex = 3
        Me.picBox.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(86, 17)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(20, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 8)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'FWaitingProcess
        '
        Me.AcceptButton = Me.btnSucceed
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(392, 138)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.picBox, Me.btnSucceed, Me.labText})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FWaitingProcess"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "正在进行中 … …"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private count As Integer
    
    Private Sub FWaitingProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
        Me.Timer1.Interval = 100 ' * 5

        Me.btnSucceed.Enabled = False
    End Sub

    Private Sub btnSucceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSucceed.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer

        Me.picBox.Image = Me.ImageList1.Images.Item(count)
        count += 1
        If count = 11 Then
            count = 0
        End If
    End Sub

    Public Sub setBtnSucced(ByVal flag As Boolean)
        count = 0
        Me.picBox.Image = Me.ImageList1.Images.Item(12)
        Me.btnSucceed.Enabled = flag
        Me.Timer1.Stop()
    End Sub

    Public Sub setLabText(ByVal strMsg As String)
        Me.labText.Text = strMsg
    End Sub
End Class
