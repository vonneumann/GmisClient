

Public Class frmAffirmGuarantFee
    Inherits frmAffirmFeeBase

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
    Friend WithEvents txtManager As System.Windows.Forms.TextBox
    Friend WithEvents lblManager As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAffirmGuarantFee))
        Me.txtManager = New System.Windows.Forms.TextBox
        Me.lblManager = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Text = "已收担保费(元)"
        '
        'lblFeeType
        '
        Me.lblFeeType.Text = "应收担保费(元)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtManager)
        Me.GroupBox1.Controls.Add(Me.lblManager)
        Me.GroupBox1.Controls.SetChildIndex(Me.lblManager, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.txtManager, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.Label6, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.Label5, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.lblFeeType, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.txtPayout, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.Label8, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.txtIncome, 0)
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.Images.SetKeyName(0, "")
        Me.ImageListBasic.Images.SetKeyName(1, "")
        Me.ImageListBasic.Images.SetKeyName(2, "")
        Me.ImageListBasic.Images.SetKeyName(3, "")
        Me.ImageListBasic.Images.SetKeyName(4, "")
        Me.ImageListBasic.Images.SetKeyName(5, "")
        Me.ImageListBasic.Images.SetKeyName(6, "")
        Me.ImageListBasic.Images.SetKeyName(7, "")
        Me.ImageListBasic.Images.SetKeyName(8, "")
        Me.ImageListBasic.Images.SetKeyName(9, "")
        Me.ImageListBasic.Images.SetKeyName(10, "")
        Me.ImageListBasic.Images.SetKeyName(11, "")
        Me.ImageListBasic.Images.SetKeyName(12, "")
        Me.ImageListBasic.Images.SetKeyName(13, "")
        Me.ImageListBasic.Images.SetKeyName(14, "")
        Me.ImageListBasic.Images.SetKeyName(15, "")
        Me.ImageListBasic.Images.SetKeyName(16, "")
        Me.ImageListBasic.Images.SetKeyName(17, "")
        Me.ImageListBasic.Images.SetKeyName(18, "")
        Me.ImageListBasic.Images.SetKeyName(19, "")
        Me.ImageListBasic.Images.SetKeyName(20, "")
        Me.ImageListBasic.Images.SetKeyName(21, "")
        Me.ImageListBasic.Images.SetKeyName(22, "")
        Me.ImageListBasic.Images.SetKeyName(23, "")
        Me.ImageListBasic.Images.SetKeyName(24, "")
        Me.ImageListBasic.Images.SetKeyName(25, "")
        Me.ImageListBasic.Images.SetKeyName(26, "")
        '
        'txtManager
        '
        Me.txtManager.BackColor = System.Drawing.SystemColors.Window
        Me.txtManager.Enabled = False
        Me.txtManager.Location = New System.Drawing.Point(256, 40)
        Me.txtManager.Name = "txtManager"
        Me.txtManager.Size = New System.Drawing.Size(80, 21)
        Me.txtManager.TabIndex = 37
        '
        'lblManager
        '
        Me.lblManager.Location = New System.Drawing.Point(188, 42)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Size = New System.Drawing.Size(64, 17)
        Me.lblManager.TabIndex = 36
        Me.lblManager.Text = "项目经理A"
        Me.lblManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAffirmGuarantFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(538, 335)
        Me.Name = "frmAffirmGuarantFee"
        Me.Text = "确认担保费收取"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ProjectCode = MyBase.getProjectCode
            CorporationName = MyBase.getCorporationName
            TaskID = MyBase.getTaskID
            WorkFlowID = MyBase.getWorkFlowID

            IsGuarantyFee = True
            SystemDate = gWs.GetSysTime
            GetDataSource("31", "002")
            txtPayout.Text = Payout.ToString("c", CGFormatInfo)
            txtincome.Text = Income.ToString("c", CGFormatInfo)

            Dim dsMan As DataSet = New DataSet()
            dsMan = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
            txtManager.DataBindings.Add("Text", dsMan, "ViewProject.24")
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
