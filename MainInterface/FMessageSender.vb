Imports System.Data.SqlClient

Public Class FMessageSender
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    'Private _Sender, _Accepter As String
    'Public Sub New(ByVal MessageSender As String, ByVal MessageAccepter As String)
    '    MyBase.New()

    '    '该调用是 Windows 窗体设计器所必需的。
    '    InitializeComponent()

    '    '在 InitializeComponent() 调用之后添加任何初始化
    '    _Sender = MessageSender
    '    _Accepter = MessageAccepter
    'End Sub

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSender As System.Windows.Forms.TextBox
    Friend WithEvents txtAccepter As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnAddAccepter As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.txtSender = New System.Windows.Forms.TextBox
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.txtAccepter = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.btnAddAccepter = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(160, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "发送人："
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Location = New System.Drawing.Point(8, 8)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(136, 368)
        Me.TreeView1.TabIndex = 1
        '
        'txtSender
        '
        Me.txtSender.Enabled = False
        Me.txtSender.Location = New System.Drawing.Point(232, 16)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Size = New System.Drawing.Size(232, 21)
        Me.txtSender.TabIndex = 2
        Me.txtSender.Text = ""
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(8, 16)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(296, 240)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = ""
        '
        'txtAccepter
        '
        Me.txtAccepter.Location = New System.Drawing.Point(8, 16)
        Me.txtAccepter.Multiline = True
        Me.txtAccepter.Name = "txtAccepter"
        Me.txtAccepter.Size = New System.Drawing.Size(296, 48)
        Me.txtAccepter.TabIndex = 5
        Me.txtAccepter.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMessage)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 264)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "消息内容："
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(272, 392)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "发送"
        '
        'btnAddAccepter
        '
        Me.btnAddAccepter.Location = New System.Drawing.Point(24, 392)
        Me.btnAddAccepter.Name = "btnAddAccepter"
        Me.btnAddAccepter.Size = New System.Drawing.Size(104, 23)
        Me.btnAddAccepter.TabIndex = 8
        Me.btnAddAccepter.Text = "添加接收人>>"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAccepter)
        Me.GroupBox2.Location = New System.Drawing.Point(152, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 72)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "接收人："
        '
        'FMessageSender
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(472, 430)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAddAccepter)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSender)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMessageSender"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "发送消息"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FMessageSender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '填充发送者
        txtSender.Text = UserName

        Dim tmpParentNode, tmpSubNode As TreeNode
        Dim tmpCheckBox As CheckBox
        Dim dsDept As DataSet = gWs.GetCommonQueryInfo("select distinct dept_name from staff where dept_name<>'编外'")
        Dim dsStaff As DataSet = gWs.GetCommonQueryInfo("select staff_name,dept_name from staff where dept_name<>'编外'")

        TreeView1.Nodes.Clear()

        '增加全体员工顶级节点
        Dim tmpAllStaffNode As TreeNode = TreeView1.Nodes.Add("全体员工")

        '填充父级（部门）节点
        For Each tmpDeptDr As DataRow In dsDept.Tables(0).Rows
            tmpParentNode = New TreeNode
            tmpParentNode.Text = tmpDeptDr.Item("dept_name")
            tmpAllStaffNode.Nodes.Add(tmpParentNode)

            '填充子级（人员）节点
            For Each tmpStaffDr As DataRow In dsStaff.Tables(0).Select("dept_name='" & tmpDeptDr.Item("dept_name") & "'")
                tmpSubNode = New TreeNode
                tmpSubNode.Text = tmpStaffDr.Item("staff_name")
                tmpParentNode.Nodes.Add(tmpSubNode)
            Next
        Next

        Me.txtAccepter.Text = strAccepter

    End Sub

    Private Sub TreeView1_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck

        If e.Action <> TreeViewAction.Unknown Then
            CheckAllChildNodes(e.Node, e.Node.Checked)
            Dim bol As Boolean = True
            If IsNothing(e.Node.Parent) = False Then
                For Each node As TreeNode In e.Node.Parent.Nodes
                    If node.Checked = False Then
                        bol = False
                    End If
                Next
                e.Node.Parent.Checked = bol
            End If
        End If


    End Sub

    Private Sub CheckAllChildNodes(ByVal treeNode As TreeNode, ByVal nodeChecked As Boolean)
        For Each node As TreeNode In treeNode.Nodes
            node.Checked = nodeChecked
            If node.Nodes.Count > 0 Then
                CheckAllChildNodes(node, nodeChecked)
            End If
        Next
    End Sub

    Public strAccepter As String = ""
    Public strSqlAccepter As String = ""
    Public strMessageContent As String = ""

    Private Sub btnAddAccepter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAccepter.Click
        '填充接收人
        strAccepter = ""
        strSqlAccepter = ""
        ScanNode(TreeView1.Nodes)
        strAccepter = strAccepter.Substring(0, strAccepter.Length - 1)
        strSqlAccepter = strSqlAccepter.Substring(0, strSqlAccepter.Length - 1)
        txtAccepter.Text = strAccepter
    End Sub

    '遍历所有员工子节点，并组成员工字符串
    Private Sub ScanNode(ByVal treeNodes As TreeNodeCollection)
        For Each node As TreeNode In treeNodes
            If node.Nodes.Count = 0 And node.Checked = True Then
                strAccepter = strAccepter + node.Text + ","
                strSqlAccepter = strSqlAccepter + "'" + node.Text + "'" + ","
            Else
                ScanNode(node.Nodes)
            End If
        Next
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If Trim(txtMessage.Text) <> "" Then

            '发送消息
            Dim dsProjectMessage As DataSet = gWs.GetWfProjectMessagesInfo("")
            Dim tmpDr As DataRow
            For Each strStaff As String In strAccepter.Split(",")
                tmpDr = dsProjectMessage.Tables(0).NewRow()
                tmpDr.Item("message_content") = txtMessage.Text.Trim & vbCrLf & strMessageContent
                tmpDr.Item("responser") = txtSender.Text.Trim
                tmpDr.Item("accepter") = strStaff
                tmpDr.Item("send_time") = Now
                tmpDr.Item("is_affirmed") = "N"
                dsProjectMessage.Tables(0).Rows.Add(tmpDr)
            Next

            '更新STAFF表的DOSCAN标志位
            Dim dsStaff As DataSet = gWs.GetStaff("%")
            For Each tmpStaffDr As DataRow In dsStaff.Tables(0).Select("staff_name in (" + strSqlAccepter + ")")
                tmpStaffDr.Item("DoScan") = True
            Next

            gWs.UpdateWfProjectMessages(dsProjectMessage)
            dsProjectMessage.AcceptChanges()
            gWs.UpdateStaff(dsStaff)
            dsStaff.AcceptChanges()

            MessageBox.Show("消息发送成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

End Class
