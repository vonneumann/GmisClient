'作者：罗庆锋；日期2003-04-05
Public Class frmWorkLog
    Inherits FWorkLog
    Implements IApplyTool

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        InitializeComponent()
    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'If Not dsLog Is Nothing Then
        '    dsLog.Dispose()
        'End If
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
    Public WithEvents btnCommit As System.Windows.Forms.Button

    Protected WithEvents Label888 As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents Label999 As System.Windows.Forms.Label
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWorkLog))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.Label888 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label999 = New System.Windows.Forms.Label()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Visible = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Bitmap)
        Me.btnCancel.ImageIndex = -1
        Me.btnCancel.ImageList = Nothing
        Me.btnCancel.Visible = True
        '
        'grdLog
        '
        Me.grdLog.AccessibleName = "DataGrid"
        Me.grdLog.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdLog.Location = New System.Drawing.Point(8, 32)
        Me.grdLog.Size = New System.Drawing.Size(856, 280)
        Me.grdLog.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Visible = True
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageIndex = -1
        Me.btnNew.ImageList = Nothing
        Me.btnNew.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnModify
        '
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Bitmap)
        Me.btnModify.ImageIndex = -1
        Me.btnModify.ImageList = Nothing
        Me.btnModify.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Location = New System.Drawing.Point(516, 588)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.TabIndex = 8
        Me.btnCommit.Text = "提交(&C)"
        '
        'Label888
        '
        Me.Label888.AutoSize = True
        Me.Label888.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label888.ForeColor = System.Drawing.Color.Black
        Me.Label888.Location = New System.Drawing.Point(17, 15)
        Me.Label888.Name = "Label888"
        Me.Label888.Size = New System.Drawing.Size(54, 14)
        Me.Label888.TabIndex = 59
        Me.Label888.Text = "项目编码"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 8)
        Me.txtProjectCode.MaxLength = 500
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtProjectCode.Size = New System.Drawing.Size(159, 21)
        Me.txtProjectCode.TabIndex = 58
        Me.txtProjectCode.Text = ""
        '
        'Label999
        '
        Me.Label999.AutoSize = True
        Me.Label999.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label999.ForeColor = System.Drawing.Color.Black
        Me.Label999.Location = New System.Drawing.Point(256, 16)
        Me.Label999.Name = "Label999"
        Me.Label999.Size = New System.Drawing.Size(54, 14)
        Me.Label999.TabIndex = 61
        Me.Label999.Text = "企业名称"
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCorName.Location = New System.Drawing.Point(320, 8)
        Me.txtCorName.MaxLength = 500
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCorName.Size = New System.Drawing.Size(544, 21)
        Me.txtCorName.TabIndex = 60
        Me.txtCorName.Text = ""
        '
        'frmWorkLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(874, 575)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnCancel, Me.btnModify, Me.btnNew, Me.btnSave, Me.btnDelete, Me.grdLog, Me.Label999, Me.txtCorName, Me.Label888, Me.txtProjectCode})
        Me.Name = "frmWorkLog"
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Protected ProjectCode As String
    Protected CorporationName As String
    Protected TaskID, taskName As String '= "PreguaranteeActivity"   ' "PreguaranteeActivity记录保前活动"  "RecordProjectProcess登记保后跟踪记录"
    Protected WorkFlowID, strUser As String
    Private dsLog, dsPeriod, dsPostAndJob, dsUserPost As DataSet
    Private SystemDate As DateTime
    'Private dgtsLog As DataGridTableStyle

    '
    '实现接口
    '
    Private Event CommitSucceed() Implements IApplyTool.CommitSucceed
    '激活事件
    Public Sub raiseCommitSucceed()
        RaiseEvent CommitSucceed()
    End Sub

    Public Sub OpenApplyTool(ByVal strProjectCode As String, ByVal strCorpName As String, ByVal strWorkFlowId As String, ByVal strTaskId As String, ByVal frmOwner As Form, ByVal User As String) Implements IApplyTool.OpenApplyTool
        Try
            Me.ProjectCode = strProjectCode
            Me.CorporationName = strCorpName
            Me.WorkFlowID = strWorkFlowId
            Me.TaskID = strTaskId
            Me.strUser = User

            Me.AllowTransparency = False
            Me.Owner = frmOwner
            Me.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    Public Sub OpenApplyTool(ByVal strProjectCode As String, ByVal strCorpName As String, ByVal strWorkFlowID As String, ByVal strTaskID As String, ByVal frmOwner As Form, ByVal User As String, ByVal taskName As String, ByVal roleID As String) Implements IApplyTool.OpenApplyTool
        Try
            Me.ProjectCode = strProjectCode
            Me.CorporationName = strCorpName
            Me.WorkFlowID = strWorkFlowID
            Me.TaskID = strTaskID
            Me.strUser = User

            Me.AllowTransparency = False
            Me.Owner = frmOwner
            Me.StartPosition = FormStartPosition.CenterScreen 'qxd add 2004-3-8
            'If Not taskName.Trim = "" Then
            '    Me.Text = taskName
            'End If
            Me.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Protected Overrides Function GetSqlQueryCondition() As String
        Return "{project_code='" & ProjectCode & "' AND task_id='" & TaskID & "' AND start_time >= '" & dtpWorkDate.Value.ToString("yyyy-MM-dd") & _
                       "' AND start_time < '" + dtpEndDate.Value.AddDays(1).ToString("yyyy-MM-dd") & "' AND attend_person = '" & _
                        UserName.ToString() & "' ORDER BY serial_num}"
    End Function

    Protected Overrides Sub SetColumnValueForNewDataRow(ByVal newRow As DataRow)
        newRow("project_code") = ProjectCode
        newRow("task_id") = TaskID
    End Sub

    Private Sub frmWorkLog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProjectCode.Text = ProjectCode
        Me.txtCorName.Text = CorporationName
    End Sub
End Class



