Public Class FTaskList
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
	Friend WithEvents tvwTask As System.Windows.Forms.TreeView
	Private WithEvents imlTask As System.Windows.Forms.ImageList
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.tvwTask = New System.Windows.Forms.TreeView()
		Me.imlTask = New System.Windows.Forms.ImageList(Me.components)
		Me.SuspendLayout()
		'
		'tvwTask
		'
		Me.tvwTask.BackColor = System.Drawing.SystemColors.Window
		Me.tvwTask.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tvwTask.ImageIndex = -1
		Me.tvwTask.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.tvwTask.Name = "tvwTask"
		Me.tvwTask.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("任务列表")})
		Me.tvwTask.SelectedImageIndex = -1
		Me.tvwTask.ShowRootLines = False
		Me.tvwTask.Size = New System.Drawing.Size(232, 256)
		Me.tvwTask.TabIndex = 0
		'
		'imlTask
		'
		Me.imlTask.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
		Me.imlTask.ImageSize = New System.Drawing.Size(16, 16)
		Me.imlTask.TransparentColor = System.Drawing.Color.Transparent
		'
		'FTaskList
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(232, 256)
		Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tvwTask})
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Name = "FTaskList"
		Me.ShowInTaskbar = False
		Me.Text = "任务列表"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Private _taskList As New ArrayList()

	Public Sub Clear()
		tvwTask.Nodes(0).Nodes.Clear()
	End Sub

	'
	'根据登录用户ID，动态生成Tree的节点
	'
	Friend Overloads Sub Refresh(ByVal userID As String)
		If userID = "" Then
			Exit Sub
		End If

		Dim ds As DataSet
		Dim dr As DataRow
		Dim i, iCounter, taskCount As Integer
		Dim strTaskName, strTaskID As String
		Dim strProjectCode, strWorkFlow, strApplyTool As String

		Dim iIndx As Integer = 0

		Dim dvTmp As DataView

		_taskList.Clear()
		'调用WebService的方法,获得某个用户的工作任务列表
		Try
			If gWs Is Nothing Then
				gWs = GetWebService(strUrl)
			End If
			ds = gWs.LookUpWorking(userID)
			dvTmp = ds.Tables(0).DefaultView
			dvTmp.Sort = "task_id ASC"

			iCounter = ds.Tables(0).Rows.Count

			For i = 0 To iCounter - 1
				dr = ds.Tables(0).Rows(i)
				With dr

					'If Not .Item("task_name") Is System.DBNull.Value Then
					strProjectCode = .Item("project_code")
					strWorkFlow = .Item("workflow_id")
					strTaskID = .Item("task_id")
					strTaskName = .Item("task_name")
					If Not .Item("Apply_tool") Is System.DBNull.Value Then
						strApplyTool = .Item("Apply_Tool")
					Else
						strApplyTool = ""
					End If

					If i = 0 Then
						tvwTask.Nodes(0).Nodes.Add(strTaskID)
						tvwTask.Nodes(0).Nodes(i).Text = strTaskName
						'iIndx += 1
						taskCount = 1
					Else
						If ds.Tables(0).Rows(i - 1).Item("task_id") <> strTaskID Then
							tvwTask.Nodes(0).Nodes(tvwTask.Nodes(0).Nodes.Count - 1).Text = tvwTask.Nodes(0).Nodes(tvwTask.Nodes(0).Nodes.Count - 1).Text + "(" + taskCount.ToString() + ")"
							tvwTask.Nodes(0).Nodes.Add(strTaskID)
							iIndx += 1
							tvwTask.Nodes(0).Nodes(iIndx).Text = strTaskName
							taskCount = 1
						Else
							taskCount += 1
						End If
					End If
					'arrayTaskID.Add(strTaskID)
					'arrayTask.Clear()
					_taskList.Add(strProjectCode)
					_taskList.Add(strWorkFlow)
					_taskList.Add(strTaskID)
					_taskList.Add(strApplyTool)
					_taskList.Add(iIndx)
					'_taskList.Add(arrayTask)
					'End If
				End With
			Next

			If tvwTask.Nodes(0).Nodes.Count > 0 Then
				tvwTask.Nodes(0).Nodes(tvwTask.Nodes(0).Nodes.Count - 1).Text = tvwTask.Nodes(0).Nodes(tvwTask.Nodes(0).Nodes.Count - 1).Text + "(" + taskCount.ToString() + ")"
				tvwTask.Nodes(0).Expand()
			End If
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

	Private Sub tvwTask_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvwTask.DoubleClick
		Dim strTaskID As String
		Dim arrTasktmp As New ArrayList()

		Dim i As Integer
		Try
			If Me.tvwTask.SelectedNode.Parent Is Nothing Then
				Exit Sub
			End If

			If _taskList.Count = 0 Then
				Exit Sub
			End If

			For i = 0 To _taskList.Count / 5 - 1
				If Me.tvwTask.SelectedNode.Index = _taskList(5 * i + 4) Then
					strTaskID = _taskList(5 * i + 2)

					'生成完成项目任务的应用程序数组
					arrTasktmp.Add(_taskList(5 * i))					'项目编码
					arrTasktmp.Add(_taskList(5 * i + 1))					  '工作流ID
					arrTasktmp.Add(_taskList(5 * i + 3))					  '应用程序
				End If
			Next

			'''''启动该任务的项目列表
			For i = 0 To Me.Owner.MdiChildren.Length - 1
				If Me.Owner.MdiChildren(i).GetType Is GetType(MainInterface.frmProjectInfo) Then
					Me.Owner.MdiChildren(i).Close()
				End If
			Next
			Dim projectInfo As frmProjectInfo = New frmProjectInfo()
			AddHandler projectInfo.TaskCommit, AddressOf getTasklistAndMsg			'当窗口关闭时，刷新任务和消息
			projectInfo.MdiParent = Me.Owner
			projectInfo.Text = Me.tvwTask.SelectedNode.Text
			projectInfo.arrTask = arrTasktmp
			projectInfo.strTaskID = strTaskID
			projectInfo.Show()
		Catch
            MessageBox.Show("打开项目列表时出错！（" & Err.Description & "）", "", MessageBoxButtons.OK)
		End Try
	End Sub

	Private Sub getTasklistAndMsg()
		Try
			'获取任务列表
			tvwTask.Nodes(0).Nodes.Clear()
			Me.Refresh(UserName)
			'展开工作列表树的所有节点
			Me.tvwTask.ExpandAll()

			'获取消息列表
			'FillLstBxMsg()
		Catch ex As Exception
			'Me.StatusBarPanel2.Text = "获取用户为：" & UserName & " 的任务列表时出错！(" & ex.Message & ")"
			MsgBox("获取用户为" & UserName & " 的任务和消息列表时出错！(" & ex.Message & ")", MsgBoxStyle.Critical, "错误")
		End Try
	End Sub
End Class
