
Public Class FConsole
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
    Friend WithEvents imlButton As System.Windows.Forms.ImageList
    Friend WithEvents ImlButton1 As System.Windows.Forms.ImageList
    Friend WithEvents btnMail As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents btnQuery As System.Windows.Forms.Label
    Friend WithEvents btnWorkLog As System.Windows.Forms.Label
    Friend WithEvents btnSystem As System.Windows.Forms.Label
    Friend WithEvents btnDocument As System.Windows.Forms.Label
    Friend WithEvents btnBusiness As System.Windows.Forms.Label
    Friend WithEvents tmrMessage As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnRefresh As System.Windows.Forms.Label
    Friend WithEvents lvwMessage As System.Windows.Forms.ListView
    Friend WithEvents ColNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColProjectCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMessage As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ImlSmall As System.Windows.Forms.ImageList
    Friend WithEvents ImlBig As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnLogin As System.Windows.Forms.Label
    Friend WithEvents btnMini As System.Windows.Forms.Label
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FConsole))
        Me.imlButton = New System.Windows.Forms.ImageList(Me.components)
        Me.btnMail = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Label
        Me.ImlButton1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnQuery = New System.Windows.Forms.Label
        Me.btnWorkLog = New System.Windows.Forms.Label
        Me.btnSystem = New System.Windows.Forms.Label
        Me.btnDocument = New System.Windows.Forms.Label
        Me.btnBusiness = New System.Windows.Forms.Label
        Me.tmrMessage = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Label
        Me.lvwMessage = New System.Windows.Forms.ListView
        Me.ColNum = New System.Windows.Forms.ColumnHeader
        Me.ColTime = New System.Windows.Forms.ColumnHeader
        Me.ColProjectCode = New System.Windows.Forms.ColumnHeader
        Me.ColMessage = New System.Windows.Forms.ColumnHeader
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ImlSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.ImlBig = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLogin = New System.Windows.Forms.Label
        Me.btnMini = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.SuspendLayout()
        '
        'imlButton
        '
        Me.imlButton.ImageStream = CType(resources.GetObject("imlButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlButton.TransparentColor = System.Drawing.Color.Transparent
        Me.imlButton.Images.SetKeyName(0, "")
        Me.imlButton.Images.SetKeyName(1, "")
        Me.imlButton.Images.SetKeyName(2, "")
        Me.imlButton.Images.SetKeyName(3, "")
        Me.imlButton.Images.SetKeyName(4, "")
        Me.imlButton.Images.SetKeyName(5, "")
        '
        'btnMail
        '
        Me.btnMail.ImageIndex = 4
        Me.btnMail.ImageList = Me.imlButton
        Me.btnMail.Location = New System.Drawing.Point(190, 235)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(64, 36)
        Me.btnMail.TabIndex = 1
        Me.btnMail.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(248, -8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(32, 36)
        Me.btnExit.TabIndex = 2
        '
        'ImlButton1
        '
        Me.ImlButton1.ImageStream = CType(resources.GetObject("ImlButton1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImlButton1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImlButton1.Images.SetKeyName(0, "")
        Me.ImlButton1.Images.SetKeyName(1, "")
        Me.ImlButton1.Images.SetKeyName(2, "")
        Me.ImlButton1.Images.SetKeyName(3, "")
        Me.ImlButton1.Images.SetKeyName(4, "")
        Me.ImlButton1.Images.SetKeyName(5, "")
        Me.ImlButton1.Images.SetKeyName(6, "")
        Me.ImlButton1.Images.SetKeyName(7, "")
        Me.ImlButton1.Images.SetKeyName(8, "")
        Me.ImlButton1.Images.SetKeyName(9, "")
        Me.ImlButton1.Images.SetKeyName(10, "")
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.Color.Transparent
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Image)
        Me.btnQuery.Location = New System.Drawing.Point(161, 299)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(80, 80)
        Me.btnQuery.TabIndex = 3
        '
        'btnWorkLog
        '
        Me.btnWorkLog.BackColor = System.Drawing.Color.Transparent
        Me.btnWorkLog.Image = CType(resources.GetObject("btnWorkLog.Image"), System.Drawing.Image)
        Me.btnWorkLog.Location = New System.Drawing.Point(143, 219)
        Me.btnWorkLog.Name = "btnWorkLog"
        Me.btnWorkLog.Size = New System.Drawing.Size(80, 80)
        Me.btnWorkLog.TabIndex = 4
        Me.btnWorkLog.Visible = False
        '
        'btnSystem
        '
        Me.btnSystem.ImageIndex = 4
        Me.btnSystem.ImageList = Me.ImlButton1
        Me.btnSystem.Location = New System.Drawing.Point(100, 69)
        Me.btnSystem.Name = "btnSystem"
        Me.btnSystem.Size = New System.Drawing.Size(123, 58)
        Me.btnSystem.TabIndex = 5
        Me.btnSystem.Visible = False
        '
        'btnDocument
        '
        Me.btnDocument.BackColor = System.Drawing.Color.Transparent
        Me.btnDocument.Image = CType(resources.GetObject("btnDocument.Image"), System.Drawing.Image)
        Me.btnDocument.Location = New System.Drawing.Point(88, 235)
        Me.btnDocument.Name = "btnDocument"
        Me.btnDocument.Size = New System.Drawing.Size(80, 80)
        Me.btnDocument.TabIndex = 6
        Me.btnDocument.Visible = False
        '
        'btnBusiness
        '
        Me.btnBusiness.BackColor = System.Drawing.Color.Transparent
        Me.btnBusiness.Image = CType(resources.GetObject("btnBusiness.Image"), System.Drawing.Image)
        Me.btnBusiness.Location = New System.Drawing.Point(43, 299)
        Me.btnBusiness.Name = "btnBusiness"
        Me.btnBusiness.Size = New System.Drawing.Size(80, 80)
        Me.btnBusiness.TabIndex = 7
        '
        'tmrMessage
        '
        Me.tmrMessage.Interval = 300000
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        '
        'btnRefresh
        '
        Me.btnRefresh.ImageIndex = 0
        Me.btnRefresh.ImageList = Me.ImageList1
        Me.btnRefresh.Location = New System.Drawing.Point(12, 250)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(66, 49)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Visible = False
        '
        'lvwMessage
        '
        Me.lvwMessage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColNum, Me.ColTime, Me.ColProjectCode, Me.ColMessage})
        Me.lvwMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lvwMessage.Location = New System.Drawing.Point(22, 59)
        Me.lvwMessage.Name = "lvwMessage"
        Me.lvwMessage.Size = New System.Drawing.Size(232, 96)
        Me.lvwMessage.TabIndex = 10
        Me.lvwMessage.UseCompatibleStateImageBehavior = False
        Me.lvwMessage.View = System.Windows.Forms.View.Details
        Me.lvwMessage.Visible = False
        '
        'ColNum
        '
        Me.ColNum.Text = "序号"
        Me.ColNum.Width = 0
        '
        'ColTime
        '
        Me.ColTime.Text = "发送时间"
        Me.ColTime.Width = 130
        '
        'ColProjectCode
        '
        Me.ColProjectCode.Text = "项目编码"
        Me.ColProjectCode.Width = 180
        '
        'ColMessage
        '
        Me.ColMessage.Text = "消息内容"
        Me.ColMessage.Width = 380
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel3.Location = New System.Drawing.Point(0, 648)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 8)
        Me.Panel3.TabIndex = 13
        '
        'ImlSmall
        '
        Me.ImlSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImlSmall.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImlSmall.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImlBig
        '
        Me.ImlBig.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImlBig.ImageSize = New System.Drawing.Size(80, 80)
        Me.ImlBig.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.Location = New System.Drawing.Point(174, 9)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(32, 36)
        Me.btnLogin.TabIndex = 14
        Me.btnLogin.Visible = False
        '
        'btnMini
        '
        Me.btnMini.BackColor = System.Drawing.Color.Transparent
        Me.btnMini.Image = CType(resources.GetObject("btnMini.Image"), System.Drawing.Image)
        Me.btnMini.Location = New System.Drawing.Point(223, -8)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(32, 36)
        Me.btnMini.TabIndex = 15
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "GMIS控制台"
        Me.NotifyIcon1.Visible = True
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = ""
        Me.SkinEngine1.SkinDialogs = False
        Me.SkinEngine1.SkinFile = "D:\60种皮肤界面ssk文件\界面ssk\DeepCyan.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'FConsole
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(285, 589)
        Me.Controls.Add(Me.btnMini)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lvwMessage)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBusiness)
        Me.Controls.Add(Me.btnDocument)
        Me.Controls.Add(Me.btnSystem)
        Me.Controls.Add(Me.btnWorkLog)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FConsole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GMIS"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaption
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _mainForm As frmMainInterface
    'Private Sub Button_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseEnter, btnLogin.MouseEnter, btnMail.MouseEnter
    '    Me.Cursor = Cursors.Hand

    '    If CType(sender, Label).ImageIndex < imlButton.Images.Count() - 1 Then
    '        CType(sender, Label).ImageIndex += 1
    '    End If
    'End Sub

    'Private Sub Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseLeave, btnLogin.MouseLeave, btnMail.MouseLeave
    '    If CType(sender, Label).ImageIndex > 0 Then
    '        CType(sender, Label).ImageIndex -= 1
    '    End If
    '    Me.Cursor = Cursors.Default
    'End Sub
    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.MouseEnter
        If CType(sender, Label).ImageIndex < Me.ImageList1.Images.Count() - 1 Then
            CType(sender, Label).ImageIndex += 1
        End If
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.MouseLeave
        If CType(sender, Label).ImageIndex > 0 Then
            CType(sender, Label).ImageIndex -= 1
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Button1_1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBusiness.MouseEnter
        'If CType(sender, Label).ImageIndex < ImlButton1.Images.Count() - 1 Then
        '    CType(sender, Label).ImageIndex += 1
        'End If
        btnBusiness.Image = Image.FromFile(Application.StartupPath & "\img\业务处理(大).png")
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBusiness.MouseLeave
        'If CType(sender, Label).ImageIndex > 0 Then
        '    CType(sender, Label).ImageIndex -= 1
        'End If
        btnBusiness.Image = Image.FromFile(Application.StartupPath & "\img\业务处理(小).png")
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub Button1_2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDocument.MouseEnter
        'If CType(sender, Label).ImageIndex < ImlButton1.Images.Count() - 1 Then
        '    CType(sender, Label).ImageIndex += 1
        'End If
        btnDocument.Image = Image.FromFile(Application.StartupPath & "\img\文档管理(大).png")
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDocument.MouseLeave
        'If CType(sender, Label).ImageIndex > 0 Then
        '    CType(sender, Label).ImageIndex -= 1
        'End If
        btnDocument.Image = Image.FromFile(Application.StartupPath & "\img\文档管理(小).png")
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button1_3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuery.MouseEnter
        'If CType(sender, Label).ImageIndex < ImlButton1.Images.Count() - 1 Then
        '    CType(sender, Label).ImageIndex += 1
        'End If
        btnQuery.Image = Image.FromFile(Application.StartupPath & "\img\综合统计(大).png")
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuery.MouseLeave
        'If CType(sender, Label).ImageIndex > 0 Then
        '    CType(sender, Label).ImageIndex -= 1
        'End If
        btnQuery.Image = Image.FromFile(Application.StartupPath & "\img\综合统计(小).png")
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button1_4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWorkLog.MouseEnter
        'If CType(sender, Label).ImageIndex < ImlButton1.Images.Count() - 1 Then
        '    CType(sender, Label).ImageIndex += 1
        'End If
        btnWorkLog.Image = Image.FromFile(Application.StartupPath & "\img\工作日志(大).png")
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWorkLog.MouseLeave
        'If CType(sender, Label).ImageIndex > 0 Then
        '    CType(sender, Label).ImageIndex -= 1
        'End If
        btnWorkLog.Image = Image.FromFile(Application.StartupPath & "\img\工作日志(小).png")
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button1_5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.MouseEnter
        'If CType(sender, Label).ImageIndex < ImlButton1.Images.Count() - 1 Then
        '    CType(sender, Label).ImageIndex += 1
        'End If
        btnLogin.Image = Image.FromFile(Application.StartupPath & "\img\重新登录(大).jpg")
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.MouseLeave
        'If CType(sender, Label).ImageIndex > 0 Then
        '    CType(sender, Label).ImageIndex -= 1
        'End If
        btnLogin.Image = Image.FromFile(Application.StartupPath & "\img\重新登录(小).jpg")
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button1_6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseEnter
        'If CType(sender, Label).ImageIndex < ImlButton1.Images.Count() - 1 Then
        '    CType(sender, Label).ImageIndex += 1
        'End If
        btnExit.Image = Image.FromFile(Application.StartupPath & "\img\退出按钮(大).png")
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseLeave
        'If CType(sender, Label).ImageIndex > 0 Then
        '    CType(sender, Label).ImageIndex -= 1
        'End If
        btnExit.Image = Image.FromFile(Application.StartupPath & "\img\退出按钮(小).png")
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button1_7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMini.MouseEnter
        'If CType(sender, Label).ImageIndex < ImlButton1.Images.Count() - 1 Then
        '    CType(sender, Label).ImageIndex += 1
        'End If
        btnMini.Image = Image.FromFile(Application.StartupPath & "\img\最小化(大).png")
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMini.MouseLeave
        'If CType(sender, Label).ImageIndex > 0 Then
        '    CType(sender, Label).ImageIndex -= 1
        'End If
        btnMini.Image = Image.FromFile(Application.StartupPath & "\img\最小化(小).png")
        Me.Cursor = Cursors.Default

    End Sub





  




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ToolTip1.AutoPopDelay = 5000
        'ToolTip1.InitialDelay = 1000
        'ToolTip1.ReshowDelay = 500

        'ToolTip1.ShowAlways = True

        ToolTip1.SetToolTip(Me.btnBusiness, "业务处理")
        ToolTip1.SetToolTip(Me.btnDocument, "文档管理")
        ToolTip1.SetToolTip(Me.btnQuery, "综合统计")
        ToolTip1.SetToolTip(Me.btnWorkLog, "工作日志")
        ToolTip1.SetToolTip(Me.btnLogin, "重新登录")
        ToolTip1.SetToolTip(Me.btnExit, "退出系统")
        ToolTip1.SetToolTip(Me.btnMini, "系统待机")
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMail.Click
        Try
            System.Diagnostics.Process.Start("OUTLOOK.EXE")
            Me.WindowState = FormWindowState.Minimized

        Catch ex As Exception
            MessageBox.Show("无法打开 OutLook，请确定是否安装。", "打开邮箱失败", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim login As SWDialogBox.LoginBox = New SWDialogBox.LoginBox

        Try
            '读取配置
            login.UserName = SWConsole.Configuration.GetAppValue("LoginBox.UserName")
            login.Server = SWConsole.Configuration.GetAppValue("LoginBox.Server")
        Catch
        End Try

        AddHandler login.Logined, AddressOf LoginedProcess

        If login.Login() Then
            If (Not _mainForm Is Nothing) AndAlso (Not _mainForm.IsDisposed) Then
                _mainForm.Close()
            End If

            Me.Refresh()
        End If
    End Sub

    Private Sub ShowMain(ByVal status As String)
        Try
            Me.Cursor = Cursors.AppStarting

            If _mainForm Is Nothing OrElse _mainForm.IsDisposed Then
                _mainForm = New frmMainInterface
            End If

            setFormMenu(_mainForm)
            _mainForm.SetStatus(status)
            _mainForm.Show()
            _mainForm.Activate()
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnWorkLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWorkLog.Click
        Me.ShowMain("WorkLog")
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        'Me.ShowMain("Query")
        'Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Minimized

        Try
            Me.Cursor = Cursors.AppStarting

            Dim strComnd As String
            strComnd = "GMISBI.exe """ & UserName & """ """ & strServer & """"
            Shell(strComnd, AppWinStyle.NormalFocus)
            'Shell("""SWUserManager.exe"" " & UserName & """ """ & strPasswd & """ " & strServer, AppWinStyle.Hide)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocument.Click
        Me.ShowMain("Document")
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystem.Click
        Me.ShowMain("System")
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnBusiness_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusiness.Click
        Me.ShowMain("Business")
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Public Shadows Sub Refresh()
        MyBase.Refresh()

        Try

            '2007-10-16 yjf add 扫描预警消息
            Try
                gWs.ScanTimingTask()
            Catch
            End Try

            Dim dsTmp As Data.DataSet
            Dim iCounter, i As Integer

            Me.Cursor = Cursors.AppStarting

            'Me.lvwMessage.Items.Clear()

            'dsTmp = gWs.LookUpMessage("{accepter='" & UserName & "' and is_affirmed<>'Y' order by send_time desc}")
            'If dsTmp Is Nothing Then
            '    Exit Sub
            'End If
            ''Me.LstBxMsg.DisplayMember = "message_content"
            ''Me.LstBxMsg.ValueMember = "serial_num" 
            ''Me.LstBxMsg.DataSource = dsTmp.Tables(0)

            ''填充listview控件
            'Dim strTime As String

            'For i = 0 To dsTmp.Tables(0).Rows.Count - 1
            '    Me.lvwMessage.Items.Add(dsTmp.Tables(0).Rows(i).Item("serial_num"))
            '    Me.lvwMessage.Items(i).SubItems.Add(dsTmp.Tables(0).Rows(i).Item("send_time").ToString())
            '    If dsTmp.Tables(0).Rows(i).Item("project_code") Is DBNull.Value Then
            '        Me.lvwMessage.Items(i).SubItems.Add("")
            '    Else
            '        Me.lvwMessage.Items(i).SubItems.Add(dsTmp.Tables(0).Rows(i).Item("project_code"))
            '    End If

            '    Me.lvwMessage.Items(i).SubItems.Add(dsTmp.Tables(0).Rows(i).Item("message_content"))
            '    If dsTmp.Tables(0).Rows(i).Item("is_affirmed") = "N" Then
            '        lvwMessage.Items(i).Font = New Font(lvwMessage.Font, FontStyle.Bold)
            '    Else
            '        lvwMessage.Items(i).Font = New Font(lvwMessage.Font, FontStyle.Regular)
            '    End If
            'Next
        Catch ex As Exception
            'SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub lvwMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.lvwMessage.Items.Count = 0 Then
            Exit Sub
        End If
        If Me.lvwMessage.FocusedItem Is Nothing Then
            Exit Sub
        End If

        Try
            Dim iNum As Int64
            Dim dsTmp As DataSet

            iNum = Me.lvwMessage.FocusedItem.Text

            dsTmp = gWs.LookUpMessage("{serial_num=" & iNum.ToString & "}")
            If Not dsTmp Is Nothing Then
                'MessageBox.Show(dsTmp.Tables(0).Rows(0).Item("message_content"), "消息内容", MessageBoxButtons.OK, MessageBoxIcon.None)
                dsTmp.Tables(0).Rows(0).Item("is_affirmed") = "R"
                gWs.UpdateMessage(dsTmp)
            End If
            If lvwMessage.FocusedItem.Font.Bold Then
                Me.lvwMessage.FocusedItem.Font = New Font(lvwMessage.Font, FontStyle.Regular)
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub FConsole_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refresh()
        End If
    End Sub

    Private Sub FMessage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()

        tmrMessage.Interval = 300000
        tmrMessage.Enabled = True
    End Sub

    Private Sub tmrMessage_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMessage.Tick
        Me.Refresh()
    End Sub

    Private Sub FConsole_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox.Show("确认退出担保系统吗？ ", "退出系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.Refresh()
    End Sub

    Private Sub btnMini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMini.Click
        Me.Hide()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDown
        Me.ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private mouseOff As New Point()
    Private mouseSet As New Point()
    Private leftFlag As Boolean
   

    Private Sub FConsole_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then

            mouseOff = New Point(-e.X, -e.Y) '得到变量的值
            leftFlag = True         '点击左键按下时标注为true;
            '点击左键按下时标注为true;
        End If
    End Sub
    Private Sub FConsole_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, MyBase.MouseMove
        If (leftFlag) Then

            mouseSet = Control.MousePosition
            mouseSet.Offset(mouseOff.X, mouseOff.Y)   '设置移动后的位置
            Location = mouseSet

        End If
    End Sub

    Private Sub FConsole_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp, MyBase.MouseUp
        If (leftFlag) Then

            leftFlag = False    '释放鼠标后标注为false

        End If
    End Sub


End Class


	