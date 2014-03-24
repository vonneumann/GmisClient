Public Class frmBasicProject
    Inherits System.Windows.Forms.Form

    'Private ws As htfServer.Service1 = gWs
    'Private strUser As String = UserName
    'Friend strTaskID As String   '任务ID

    'Friend arrTask As ArrayList

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
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents project_group As System.Windows.Forms.GroupBox
    Public WithEvents dgQueryResult As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBasicProject))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.project_group = New System.Windows.Forms.GroupBox()
        Me.dgQueryResult = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.project_group.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 0
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(464, 392)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'project_group
        '
        Me.project_group.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.project_group.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgQueryResult})
        Me.project_group.Location = New System.Drawing.Point(13, 16)
        Me.project_group.Name = "project_group"
        Me.project_group.Size = New System.Drawing.Size(568, 360)
        Me.project_group.TabIndex = 2
        Me.project_group.TabStop = False
        Me.project_group.Text = "项目信息"
        '
        'dgQueryResult
        '
        Me.dgQueryResult.CaptionVisible = False
        Me.dgQueryResult.DataMember = ""
        Me.dgQueryResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgQueryResult.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQueryResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgQueryResult.Location = New System.Drawing.Point(3, 17)
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.ReadOnly = True
        Me.dgQueryResult.Size = New System.Drawing.Size(562, 340)
        Me.dgQueryResult.TabIndex = 0
        Me.dgQueryResult.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgQueryResult
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmBasicProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 435)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.project_group, Me.btnExit})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBasicProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "请修改标题"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.project_group.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmBasic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim s As Screen
        's = Screen.AllScreens(0)
        'Dim width, height As Integer
        'width = s.WorkingArea.Width
        'height = s.WorkingArea.Height
        'If ((width >= 1024) And (height >= 768)) Then
        '    If (Me.MdiParent.Width > 852) And (Me.MdiParent.Height > 602) Then
        '        Me.Scale(1.2, 1.2)
        '        Me.Width = 600 * 1.2
        '        Me.Height = 480 * 1.2
        '    End If
        'End If
        'Me.Location = New Point(0, 0)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Protected Sub CreateDtGrig(ByVal strTableName As String)
        Try
            dgQueryResult.TableStyles(0).GridColumnStyles.Clear()
            dgQueryResult.TableStyles(0).MappingName = strTableName
            Dim colProCode As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            colProCode.MappingName = "ProjectCode"
            colProCode.HeaderText = "项目编码"
            colProCode.Alignment = HorizontalAlignment.Left
            colProCode.Width = 65
            colProCode.NullText = String.Empty
            dgQueryResult.TableStyles(0).GridColumnStyles.Add(colProCode)

            Dim colCorpName As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            colCorpName.MappingName = "EnterpriseName"
            colCorpName.HeaderText = "企业名称"
            colCorpName.Alignment = HorizontalAlignment.Left
            colCorpName.Width = 150
            colCorpName.NullText = String.Empty
            dgQueryResult.TableStyles(0).GridColumnStyles.Add(colCorpName)

            Dim colphase As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            colphase.MappingName = "phase"
            colphase.HeaderText = "阶段"
            colphase.Alignment = HorizontalAlignment.Left
            colphase.Width = 40
            colphase.NullText = String.Empty
            dgQueryResult.TableStyles(0).GridColumnStyles.Add(colphase)

            Dim colStatus As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            colStatus.MappingName = "Status"
            colStatus.HeaderText = "状态"
            colStatus.Alignment = HorizontalAlignment.Left
            colStatus.Width = 60
            colStatus.NullText = String.Empty
            dgQueryResult.TableStyles(0).GridColumnStyles.Add(colStatus)

            Dim colPreTask As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            colPreTask.MappingName = "previous_task_name"
            colPreTask.HeaderText = "前置任务"
            colPreTask.Alignment = HorizontalAlignment.Left
            colPreTask.Width = 110
            colPreTask.NullText = String.Empty
            dgQueryResult.TableStyles(0).GridColumnStyles.Add(colPreTask)

            Dim colPreTaskFisher As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            colPreTaskFisher.MappingName = "previous_task_attendee"
            colPreTaskFisher.HeaderText = "前置任务完成人"
            colPreTaskFisher.Alignment = HorizontalAlignment.Left
            colPreTaskFisher.Width = 95
            colPreTaskFisher.NullText = String.Empty
            dgQueryResult.TableStyles(0).GridColumnStyles.Add(colPreTaskFisher)

            Dim colTaskStart As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            colTaskStart.MappingName = "start_time"
            colTaskStart.HeaderText = "任务开始时间"
            colTaskStart.Alignment = HorizontalAlignment.Left
            colTaskStart.Width = 110
            colTaskStart.NullText = String.Empty
			colTaskStart.Format = "yyyy-MM-dd HH:mm"
            dgQueryResult.TableStyles(0).GridColumnStyles.Add(colTaskStart)

            Dim colTerm As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            colTerm.MappingName = "time_limit"
            colTerm.HeaderText = "允许滞留时间(天）"
            colTerm.Alignment = HorizontalAlignment.Right
            colTerm.Width = 110
            colTerm.NullText = String.Empty
            dgQueryResult.TableStyles(0).GridColumnStyles.Add(colTerm)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class
