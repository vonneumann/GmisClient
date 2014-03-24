Imports System.Data.SqlClient

Public Class NoteBox
    Inherits System.Windows.Forms.Form
    Private screenWidth As Integer   '屏幕宽度
    Private screenHeight As Integer  '屏幕高度
    Private finished As Boolean = False  '是否完全显示提示窗口
    Private tmpMessageDr As DataRow
    Private _sender, _accepter As String
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New(ByVal MessageDataRow As DataRow)
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

        screenHeight = Screen.PrimaryScreen.Bounds.Height
        screenWidth = Screen.PrimaryScreen.Bounds.Width
        '设置提示窗口坐标在屏幕可显示区域之外
        Location = New Point(screenWidth - Width - 5, screenHeight)
        'Location = New Point(5, screenHeight)

        tmpMessageDr = MessageDataRow

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnRevert As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnRevert = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMessage.Location = New System.Drawing.Point(12, 16)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(268, 72)
        Me.txtMessage.TabIndex = 1
        Me.txtMessage.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.Location = New System.Drawing.Point(32, 96)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "知道了"
        '
        'btnRevert
        '
        Me.btnRevert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRevert.Location = New System.Drawing.Point(184, 96)
        Me.btnRevert.Name = "btnRevert"
        Me.btnRevert.TabIndex = 3
        Me.btnRevert.Text = "回复"
        '
        'NoteBox
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(292, 136)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRevert)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NoteBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "消息"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If finished = False Then '如果提示窗口没有完全显示

            '如果提示窗口的纵坐标与提示窗口的高度之和大于屏幕高度
            If Location.Y + Height >= screenHeight - 20 Then

                Location = New Point(Location.X, Location.Y - 50)
            End If
        Else '如果提示窗口已经完成了显示，并且点击了确定按钮

            '如果提示窗口没有完全从屏幕上消失
            If Location.Y < screenHeight Then

                Location = New Point(Location.X, Location.Y + 50)

            End If

        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        '设置完成了显示，以便让提示控件移出屏幕可显示区域
        finished = True

        '将消息已阅标志置为真
        tmpMessageDr.Item("is_affirmed") = "Y"
        gWs.UpdateMessage(tmpMessageDr.Table.DataSet)
        tmpMessageDr.AcceptChanges()

    End Sub

    Private Sub NoteBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strResponser As String
        _sender = IIf(IsDBNull(tmpMessageDr.Item("responser")), "", tmpMessageDr.Item("responser"))
        _accepter = IIf(IsDBNull(tmpMessageDr.Item("accepter")), "", tmpMessageDr.Item("accepter"))

        If _sender = "" Then
            Me.btnRevert.Enabled = False
        Else
            Me.btnRevert.Enabled = True
        End If

        If IsDBNull(tmpMessageDr.Item("responser")) Then
            strResponser = "系统消息" + " " + tmpMessageDr.Item("send_time")
        Else
            strResponser = tmpMessageDr.Item("responser") + " " + tmpMessageDr.Item("send_time")
        End If
        txtMessage.Text = strResponser & vbCrLf & "      " & tmpMessageDr.Item("message_content")

        '将消息记录置为已发送
        tmpMessageDr.Item("is_affirmed") = "S"
        gWs.UpdateMessage(tmpMessageDr.Table.DataSet)
        tmpMessageDr.AcceptChanges()

    End Sub

    Private Sub btnRevert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevert.Click
        Try
            Me.Cursor = Cursors.AppStarting

            Dim _messageSender As New FMessageSender
            _messageSender.strSqlAccepter = "'" & _sender & "'"
            _messageSender.strAccepter = _sender
            _messageSender.strMessageContent = txtMessage.Text
            _messageSender.Owner = Me
            _messageSender.ShowDialog()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class
