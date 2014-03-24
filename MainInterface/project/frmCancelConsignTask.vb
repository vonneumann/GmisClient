'取消委托窗体
Public Class frmCancelConsignTask
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgConsign As System.Windows.Forms.DataGrid
    Friend WithEvents btnEntery As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csStaffName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csRoleID As DataGridComboBoxColumn
    Friend WithEvents csConsinger As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chk_currentTask As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCancelConsignTask))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgConsign = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csStaffName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRoleID = New MainInterface.DataGridComboBoxColumn()
        Me.csConsinger = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnEntery = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chk_currentTask = New System.Windows.Forms.CheckBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgConsign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgConsign})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 328)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "委托关系"
        '
        'dgConsign
        '
        Me.dgConsign.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dgConsign.CaptionVisible = False
        Me.dgConsign.DataMember = ""
        Me.dgConsign.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgConsign.Location = New System.Drawing.Point(3, 16)
        Me.dgConsign.Name = "dgConsign"
        Me.dgConsign.Size = New System.Drawing.Size(402, 309)
        Me.dgConsign.TabIndex = 0
        Me.dgConsign.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgConsign
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csStaffName, Me.csRoleID, Me.csConsinger})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TStaffRole"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'csStaffName
        '
        Me.csStaffName.Format = ""
        Me.csStaffName.FormatInfo = Nothing
        Me.csStaffName.HeaderText = "委托人"
        Me.csStaffName.MappingName = "staff_name"
        Me.csStaffName.NullText = ""
        Me.csStaffName.Width = 75
        '
        'csRoleID
        '
        Me.csRoleID.Format = ""
        Me.csRoleID.FormatInfo = Nothing
        Me.csRoleID.HeaderText = "角色"
        Me.csRoleID.MappingName = "role_id"
        Me.csRoleID.Width = 75
        '
        'csConsinger
        '
        Me.csConsinger.Format = ""
        Me.csConsinger.FormatInfo = Nothing
        Me.csConsinger.HeaderText = "受托人"
        Me.csConsinger.MappingName = "consigner"
        Me.csConsinger.NullText = ""
        Me.csConsinger.Width = 75
        '
        'btnEntery
        '
        Me.btnEntery.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntery.ImageIndex = 0
        Me.btnEntery.ImageList = Me.ImageList1
        Me.btnEntery.Location = New System.Drawing.Point(128, 368)
        Me.btnEntery.Name = "btnEntery"
        Me.btnEntery.Size = New System.Drawing.Size(77, 23)
        Me.btnEntery.TabIndex = 1
        Me.btnEntery.Text = "确 定(&O)"
        Me.btnEntery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Bitmap)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 1
        Me.btnCancel.ImageList = Me.ImageList1
        Me.btnCancel.Location = New System.Drawing.Point(216, 368)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "退 出(&X)"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_currentTask
        '
        Me.chk_currentTask.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.chk_currentTask.Location = New System.Drawing.Point(16, 336)
        Me.chk_currentTask.Name = "chk_currentTask"
        Me.chk_currentTask.Size = New System.Drawing.Size(112, 24)
        Me.chk_currentTask.TabIndex = 3
        Me.chk_currentTask.Text = "撤销当前任务"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmCancelConsignTask
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(424, 397)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chk_currentTask, Me.btnCancel, Me.btnEntery, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCancelConsignTask"
        Me.Text = "撤销委托"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgConsign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsStaffRole, dsRole As DataSet
    Dim tmpStaff, tmpRoleName, tmpRoleID As String
    Dim iIndex As Integer
    Public Event refreshTaskCommit()

    Private Sub frmCancelConsignTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '获取办理了委托的员工角色数据集
        dsStaffRole = gWs.GetStaffByRoleID("{isnull(consigner,'')<>'' }")
        'dsStaffRole.Tables(0).DefaultView.Sort = "staff_name"

        If dsStaffRole.Tables("TStaffRole").Rows.Count <= 0 Then
            Me.btnEntery.Enabled = False
            Exit Sub
        End If

        '在列表中显示该员工角色数据集
        dgConsign.SetDataBinding(dsStaffRole, "TStaffRole")



        '获取所有的角色数据集
        dsRole = gWs.GetRole("%")

        '将该角色数据集帮定到角色选择下拉列表
        csRoleID.ColumnComboBox.DataSource = dsRole.Tables("TRole").DefaultView
        csRoleID.ColumnComboBox.DisplayMember = "role_name"
        csRoleID.ColumnComboBox.ValueMember = "role_id"

        '设置数据表格不能新增
        setDgAttribute(dgConsign, Me)
    End Sub


    Private Sub btnEntery_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        iIndex = dgConsign.CurrentRowIndex

        '获取受托人,角色名
        Dim tmpSrcPerson As String = dgConsign.Item(iIndex, 0)
        tmpStaff = IIf(IsDBNull(dgConsign.Item(iIndex, 2)), "", dgConsign.Item(iIndex, 2))
        tmpRoleName = Trim(dgConsign.Item(iIndex, 1))

        '判断是否有受托人(如果没有,不能撤销委托)
        If tmpStaff = "" Then
            MsgBox("没有办理委托,不能撤销委托", MsgBoxStyle.Information, "取消委托")
            Exit Sub
        End If

        '获取该角色名的ID号
        Dim strSql As String = "role_name='" & tmpRoleName & "'"
        tmpRoleID = dsRole.Tables(0).Select(strSql)(0).Item("role_id")

        Dim response As MsgBoxResult
        Dim strErr As String
        response = MsgBox("是否确认要撤销委托!", MsgBoxStyle.YesNo, "取消委托")

        '调用CancelconsignTask方法取消委托
        If response = MsgBoxResult.Yes Then
            strErr = gWs.CancelconsignTask(tmpSrcPerson, tmpStaff, tmpRoleID, chk_currentTask.Checked)
            If strErr = "1" Then
                MsgBox("撤销委托成功!", MsgBoxStyle.Information, "取消委托")

                '将网格中的受托人置空
                strSql = "role_id='" & tmpRoleID & "' and staff_name='" & tmpSrcPerson & "'"
                dsStaffRole.Tables(0).Select(strSql)(0).Item("consigner") = DBNull.Value
                dsStaffRole.AcceptChanges()
                RaiseEvent refreshTaskCommit()

            Else
                MsgBox("撤销委托失败:" & strErr, MsgBoxStyle.Critical, "取消委托")
                Exit Sub
            End If
        End If

     
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
