Public Class FMasterDetailDataForm
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
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
    Friend WithEvents grdMaster As System.Windows.Forms.DataGrid
    Friend WithEvents grdDetail As System.Windows.Forms.DataGrid
    Friend WithEvents splHorizontal As System.Windows.Forms.Splitter
    Protected Friend WithEvents mnuDeleteContext As System.Windows.Forms.ContextMenu
    Protected Friend WithEvents mnuDeleteMaster As System.Windows.Forms.MenuItem
    Protected Friend WithEvents mnuDeleteDetail As System.Windows.Forms.MenuItem
    Protected Friend WithEvents mnuInsertContext As System.Windows.Forms.ContextMenu
    Protected Friend WithEvents mnuInsertMaster As System.Windows.Forms.MenuItem
    Protected Friend WithEvents mnuInsertDetail As System.Windows.Forms.MenuItem
    Protected Friend WithEvents btnExit As System.Windows.Forms.Button
    Protected Friend WithEvents btnDelete As System.Windows.Forms.Button
    Protected Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Protected Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Protected Friend WithEvents btnInsert As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FMasterDetailDataForm))
        Me.grdMaster = New System.Windows.Forms.DataGrid()
        Me.splHorizontal = New System.Windows.Forms.Splitter()
        Me.grdDetail = New System.Windows.Forms.DataGrid()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.mnuDeleteContext = New System.Windows.Forms.ContextMenu()
        Me.mnuDeleteMaster = New System.Windows.Forms.MenuItem()
        Me.mnuDeleteDetail = New System.Windows.Forms.MenuItem()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.mnuInsertContext = New System.Windows.Forms.ContextMenu()
        Me.mnuInsertMaster = New System.Windows.Forms.MenuItem()
        Me.mnuInsertDetail = New System.Windows.Forms.MenuItem()
        Me.btnInsert = New System.Windows.Forms.Button()
        CType(Me.grdMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdMaster
        '
        Me.grdMaster.CaptionVisible = False
        Me.grdMaster.CausesValidation = False
        Me.grdMaster.DataMember = ""
        Me.grdMaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdMaster.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdMaster.Location = New System.Drawing.Point(8, 8)
        Me.grdMaster.Name = "grdMaster"
        Me.grdMaster.Size = New System.Drawing.Size(496, 160)
        Me.grdMaster.TabIndex = 0
        '
        'splHorizontal
        '
        Me.splHorizontal.Dock = System.Windows.Forms.DockStyle.Top
        Me.splHorizontal.Location = New System.Drawing.Point(8, 168)
        Me.splHorizontal.MinExtra = 80
        Me.splHorizontal.MinSize = 0
        Me.splHorizontal.Name = "splHorizontal"
        Me.splHorizontal.Size = New System.Drawing.Size(496, 4)
        Me.splHorizontal.TabIndex = 1
        Me.splHorizontal.TabStop = False
        '
        'grdDetail
        '
        Me.grdDetail.CaptionVisible = False
        Me.grdDetail.CausesValidation = False
        Me.grdDetail.DataMember = ""
        Me.grdDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDetail.Location = New System.Drawing.Point(8, 172)
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.Size = New System.Drawing.Size(496, 121)
        Me.grdDetail.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnExit.Location = New System.Drawing.Point(392, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.CausesValidation = False
        Me.btnDelete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnDelete.Location = New System.Drawing.Point(216, 304)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuDeleteContext
        '
        Me.mnuDeleteContext.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDeleteMaster, Me.mnuDeleteDetail})
        '
        'mnuDeleteMaster
        '
        Me.mnuDeleteMaster.Index = 0
        Me.mnuDeleteMaster.Text = "删除主表当前行(&M)"
        '
        'mnuDeleteDetail
        '
        Me.mnuDeleteDetail.Index = 1
        Me.mnuDeleteDetail.Text = "删除从表当前行(&C)"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefresh.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnRefresh.Location = New System.Drawing.Point(40, 304)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 24)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "刷 新(&R)"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnUpdate.Location = New System.Drawing.Point(304, 304)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 24)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "保 存(&S)"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuInsertContext
        '
        Me.mnuInsertContext.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuInsertMaster, Me.mnuInsertDetail})
        '
        'mnuInsertMaster
        '
        Me.mnuInsertMaster.Index = 0
        Me.mnuInsertMaster.Text = "新增主表记录(&M)"
        '
        'mnuInsertDetail
        '
        Me.mnuInsertDetail.Index = 1
        Me.mnuInsertDetail.Text = "新增从表记录(&C)"
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnInsert.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnInsert.Image = CType(resources.GetObject("btnInsert.Image"), System.Drawing.Bitmap)
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnInsert.Location = New System.Drawing.Point(128, 304)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(80, 24)
        Me.btnInsert.TabIndex = 14
        Me.btnInsert.Text = "新 增(&N)"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FMasterDetailDataForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnInsert, Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdDetail, Me.splHorizontal, Me.grdMaster})
        Me.DockPadding.Bottom = 40
        Me.DockPadding.Left = 8
        Me.DockPadding.Right = 8
        Me.DockPadding.Top = 8
        Me.Name = "FMasterDetailDataForm"
        CType(Me.grdMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "虚拟方法"
    Public Overridable Function RefreshData() As Boolean
        grdMaster.Enabled = True
        grdDetail.Enabled = True

        btnInsert.Text = "新 增(&N)"

        If Not grdMaster.DataSource Is Nothing Then
            Dim masterManager As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)

            CType(masterManager.List, DataView).AllowNew = False
        End If

        If Not grdDetail.DataSource Is Nothing Then
            Dim detailManager As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)

            CType(detailManager.List, DataView).AllowNew = False
        End If

        Return True
    End Function

    Public Overridable Function UpdateData() As Boolean
        If grdMaster.DataSource Is Nothing OrElse grdDetail.DataSource Is Nothing Then
            Return False
        End If

        Dim dsMaster As DataSet = CType(grdMaster.DataSource, DataSet)
        Dim dsDetail As DataSet = CType(grdDetail.DataSource, DataSet)

        If Not dsMaster Is Nothing Then
            If Not ValidateMaster(dsMaster.Tables(grdMaster.DataMember)) Then
                Return False
            End If
        End If
        If Not dsDetail Is Nothing Then
            If Not ValidateDetail(dsDetail.Tables(grdDetail.DataMember)) Then
                Return False
            End If
        End If

        Return True
    End Function

    Protected Overridable Function ValidateMaster(ByVal table As DataTable) As Boolean
        Return True
    End Function

    Protected Overridable Function ValidateDetail(ByVal table As DataTable) As Boolean
        Return True
    End Function

    Protected Overridable Function DeleteMasterConfirm() As DialogResult
        Return SWDialogBox.MessageBox.Show("?1004", "")
    End Function

    Protected Overridable Function DeleteDetailConfirm() As DialogResult
        Return SWDialogBox.MessageBox.Show("?1004", "")
    End Function

    Protected Overridable Function ClosingConfirm() As Boolean
        Dim dsMaster As DataSet = CType(grdMaster.DataSource, DataSet)
        Dim dsDetail As DataSet = CType(grdDetail.DataSource, DataSet)

        If dsMaster Is Nothing OrElse dsDetail Is Nothing Then
            Return False
        Else
            If (Not dsMaster.HasChanges()) AndAlso (Not dsDetail.HasChanges()) Then
                Return False
            End If
        End If

        '资料已经被改动过，您要保存吗？
        Dim result As DialogResult = SWDialogBox.MessageBox.Show("?1003")

        If result = DialogResult.Yes Then
            If Not Me.UpdateData() Then
                Return True
            End If
        Else
            If result = DialogResult.Cancel Then
                Return True
            End If
        End If
    End Function
#End Region

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = ClosingConfirm()
    End Sub

    Private Sub Form_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState <> FormWindowState.Minimized And splHorizontal.Top > Me.ClientSize.Height - Me.DockPadding.Top - Me.DockPadding.Bottom Then
            splHorizontal.SplitPosition = Me.ClientSize.Height - Me.DockPadding.Top - Me.DockPadding.Bottom - splHorizontal.MinSize
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        mnuDeleteContext.Show(btnDelete, New Point(0, btnDelete.Height))
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If grdMaster.DataSource Is Nothing OrElse grdDetail.DataSource Is Nothing Then
            Return
        End If

        Dim masterManager As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        Dim detailManager As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)

        If CType(masterManager.List, DataView).AllowNew OrElse CType(detailManager.List, DataView).AllowNew Then
            grdMaster.Enabled = True
            grdDetail.Enabled = True
            CType(masterManager.List, DataView).AllowNew = False
            CType(detailManager.List, DataView).AllowNew = False
            btnInsert.Text = "新 增(&N)"
        Else
            mnuInsertContext.Show(btnInsert, New Point(0, btnInsert.Height))
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.RefreshData()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Me.UpdateData() Then
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        End If
    End Sub

    Private Sub mnuDeleteContext_Popup(ByVal sender As Object, ByVal e As EventArgs) Handles mnuDeleteContext.Popup
        mnuDeleteMaster.Enabled = Not (grdMaster.DataSource Is Nothing)
        mnuDeleteDetail.Enabled = Not (grdDetail.DataSource Is Nothing)

        If mnuDeleteMaster.Enabled Then
            mnuDeleteMaster.Enabled = (Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember).Position >= 0)
        End If

        If mnuDeleteDetail.Enabled Then
            mnuDeleteDetail.Enabled = (Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember).Position >= 0)
        End If
    End Sub

    Private Sub mnuDeleteMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteMaster.Click
        If grdMaster.DataSource Is Nothing Then
            Return
        End If

        Dim cm As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        If cm.Count <= 0 Then
            Return
        End If

        '确认要删除该项数据（记录）吗？
        If DeleteMasterConfirm() = DialogResult.Yes Then
            CType(cm.Current, DataRowView).Delete()
            '强制刷新从表数据
            'MasterTable_PositionChanged(cm, EventArgs.Empty)
        End If
    End Sub

    Private Sub mnuDeleteDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteDetail.Click
        If grdDetail.DataSource Is Nothing Then
            Return
        End If

        Dim cm As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)
        If cm.Count <= 0 Then
            Return
        End If

        '确认要删除该项数据（记录）吗？
        If DeleteDetailConfirm() = DialogResult.Yes Then
            CType(cm.Current, DataRowView).Delete()
        End If
    End Sub

    Private Sub mnuInsertContext_Popup(ByVal sender As Object, ByVal e As EventArgs) Handles mnuInsertContext.Popup
        mnuInsertMaster.Enabled = Not (grdMaster.DataSource Is Nothing)
        mnuInsertDetail.Enabled = Not (grdDetail.DataSource Is Nothing)
    End Sub

    Private Sub mnuInsertMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsertMaster.Click
        Dim masterManager As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        Dim detailManager As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)

        btnInsert.Text = "取 消(&C)"

        grdMaster.Enabled = True
        grdDetail.Enabled = False

        CType(detailManager.List, DataView).AllowNew = False
        CType(masterManager.List, DataView).AllowNew = True
    End Sub

    Private Sub mnuInsertDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsertDetail.Click
        Dim masterManager As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        Dim detailManager As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)

        btnInsert.Text = "取 消(&C)"

        grdMaster.Enabled = False
        grdDetail.Enabled = True

        CType(masterManager.List, DataView).AllowNew = False
        CType(detailManager.List, DataView).AllowNew = True
    End Sub
End Class
