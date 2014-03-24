Public Class FImportFinance
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
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents lblPhase As System.Windows.Forms.Label
    Friend WithEvents grpFrom As System.Windows.Forms.GroupBox
    Friend WithEvents grpTo As System.Windows.Forms.GroupBox
    Friend WithEvents btnMoveRight As System.Windows.Forms.Button
    Friend WithEvents btnMoveLeft As System.Windows.Forms.Button
    Friend WithEvents lblProCode As System.Windows.Forms.Label
    Friend WithEvents txtProCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grpLocal As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhase As System.Windows.Forms.TextBox
    Friend WithEvents lvFrom As System.Windows.Forms.ListView
    Friend WithEvents lvTo As System.Windows.Forms.ListView
    Friend WithEvents lvLocal As System.Windows.Forms.ListView
    Friend WithEvents FromProCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents FromPhase As System.Windows.Forms.ColumnHeader
    Friend WithEvents FromMonth As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToProCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToPhase As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToMonth As System.Windows.Forms.ColumnHeader
    Friend WithEvents LocalProCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents LocalPhase As System.Windows.Forms.ColumnHeader
    Friend WithEvents LocalMonth As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FImportFinance))
        Me.lblCorpName = New System.Windows.Forms.Label
        Me.lblProCode = New System.Windows.Forms.Label
        Me.lblPhase = New System.Windows.Forms.Label
        Me.grpFrom = New System.Windows.Forms.GroupBox
        Me.lvFrom = New System.Windows.Forms.ListView
        Me.FromProCode = New System.Windows.Forms.ColumnHeader
        Me.FromPhase = New System.Windows.Forms.ColumnHeader
        Me.FromMonth = New System.Windows.Forms.ColumnHeader
        Me.grpTo = New System.Windows.Forms.GroupBox
        Me.lvTo = New System.Windows.Forms.ListView
        Me.ToProCode = New System.Windows.Forms.ColumnHeader
        Me.ToPhase = New System.Windows.Forms.ColumnHeader
        Me.ToMonth = New System.Windows.Forms.ColumnHeader
        Me.txtProCode = New System.Windows.Forms.TextBox
        Me.txtCorpName = New System.Windows.Forms.TextBox
        Me.btnImport = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnMoveRight = New System.Windows.Forms.Button
        Me.btnMoveLeft = New System.Windows.Forms.Button
        Me.grpLocal = New System.Windows.Forms.GroupBox
        Me.lvLocal = New System.Windows.Forms.ListView
        Me.LocalProCode = New System.Windows.Forms.ColumnHeader
        Me.LocalPhase = New System.Windows.Forms.ColumnHeader
        Me.LocalMonth = New System.Windows.Forms.ColumnHeader
        Me.txtPhase = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.grpFrom.SuspendLayout()
        Me.grpTo.SuspendLayout()
        Me.grpLocal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCorpName
        '
        Me.lblCorpName.Location = New System.Drawing.Point(16, 40)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpName.TabIndex = 2
        Me.lblCorpName.Text = "企业名称"
        '
        'lblProCode
        '
        Me.lblProCode.Location = New System.Drawing.Point(16, 16)
        Me.lblProCode.Name = "lblProCode"
        Me.lblProCode.Size = New System.Drawing.Size(80, 16)
        Me.lblProCode.TabIndex = 3
        Me.lblProCode.Text = "项目编码"
        '
        'lblPhase
        '
        Me.lblPhase.Location = New System.Drawing.Point(208, 16)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(80, 16)
        Me.lblPhase.TabIndex = 4
        Me.lblPhase.Text = "阶段"
        '
        'grpFrom
        '
        Me.grpFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpFrom.Controls.Add(Me.lvFrom)
        Me.grpFrom.Location = New System.Drawing.Point(8, 64)
        Me.grpFrom.Name = "grpFrom"
        Me.grpFrom.Size = New System.Drawing.Size(248, 368)
        Me.grpFrom.TabIndex = 5
        Me.grpFrom.TabStop = False
        Me.grpFrom.Text = "企业财务数据"
        '
        'lvFrom
        '
        Me.lvFrom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FromProCode, Me.FromPhase, Me.FromMonth})
        Me.lvFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvFrom.FullRowSelect = True
        Me.lvFrom.HideSelection = False
        Me.lvFrom.Location = New System.Drawing.Point(3, 17)
        Me.lvFrom.MultiSelect = False
        Me.lvFrom.Name = "lvFrom"
        Me.lvFrom.Size = New System.Drawing.Size(242, 348)
        Me.lvFrom.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvFrom.TabIndex = 0
        Me.lvFrom.View = System.Windows.Forms.View.Details
        '
        'FromProCode
        '
        Me.FromProCode.Text = "项目编码"
        '
        'FromPhase
        '
        Me.FromPhase.Text = "阶段"
        '
        'FromMonth
        '
        Me.FromMonth.Text = "年月"
        '
        'grpTo
        '
        Me.grpTo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTo.Controls.Add(Me.lvTo)
        Me.grpTo.Location = New System.Drawing.Point(312, 64)
        Me.grpTo.Name = "grpTo"
        Me.grpTo.Size = New System.Drawing.Size(248, 232)
        Me.grpTo.TabIndex = 6
        Me.grpTo.TabStop = False
        Me.grpTo.Text = "项目财务数据"
        '
        'lvTo
        '
        Me.lvTo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ToProCode, Me.ToPhase, Me.ToMonth})
        Me.lvTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTo.FullRowSelect = True
        Me.lvTo.HideSelection = False
        Me.lvTo.Location = New System.Drawing.Point(3, 17)
        Me.lvTo.MultiSelect = False
        Me.lvTo.Name = "lvTo"
        Me.lvTo.Size = New System.Drawing.Size(242, 212)
        Me.lvTo.TabIndex = 0
        Me.lvTo.View = System.Windows.Forms.View.Details
        '
        'ToProCode
        '
        Me.ToProCode.Text = "项目编码"
        '
        'ToPhase
        '
        Me.ToPhase.Text = "阶段"
        '
        'ToMonth
        '
        Me.ToMonth.Text = "年月"
        '
        'txtProCode
        '
        Me.txtProCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProCode.Location = New System.Drawing.Point(88, 14)
        Me.txtProCode.Name = "txtProCode"
        Me.txtProCode.Size = New System.Drawing.Size(104, 21)
        Me.txtProCode.TabIndex = 7
        Me.txtProCode.Text = ""
        '
        'txtCorpName
        '
        Me.txtCorpName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorpName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorpName.Location = New System.Drawing.Point(88, 37)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(456, 22)
        Me.txtCorpName.TabIndex = 8
        Me.txtCorpName.Text = ""
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.ImageIndex = 0
        Me.btnImport.ImageList = Me.ImageList1
        Me.btnImport.Location = New System.Drawing.Point(376, 440)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 24)
        Me.btnImport.TabIndex = 10
        Me.btnImport.Text = "  导 入(&I)"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 1
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(464, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "  退 出(&X)"
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Location = New System.Drawing.Point(256, 128)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(56, 24)
        Me.btnMoveRight.TabIndex = 7
        Me.btnMoveRight.Text = ">>>"
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Location = New System.Drawing.Point(256, 168)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(56, 24)
        Me.btnMoveLeft.TabIndex = 8
        Me.btnMoveLeft.Text = "<<<"
        '
        'grpLocal
        '
        Me.grpLocal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLocal.Controls.Add(Me.lvLocal)
        Me.grpLocal.Location = New System.Drawing.Point(312, 296)
        Me.grpLocal.Name = "grpLocal"
        Me.grpLocal.Size = New System.Drawing.Size(248, 136)
        Me.grpLocal.TabIndex = 12
        Me.grpLocal.TabStop = False
        Me.grpLocal.Text = "已存在的财务数据"
        '
        'lvLocal
        '
        Me.lvLocal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LocalProCode, Me.LocalPhase, Me.LocalMonth})
        Me.lvLocal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLocal.FullRowSelect = True
        Me.lvLocal.Location = New System.Drawing.Point(3, 17)
        Me.lvLocal.Name = "lvLocal"
        Me.lvLocal.Size = New System.Drawing.Size(242, 116)
        Me.lvLocal.TabIndex = 0
        Me.lvLocal.View = System.Windows.Forms.View.Details
        '
        'LocalProCode
        '
        Me.LocalProCode.Text = "项目编码"
        '
        'LocalPhase
        '
        Me.LocalPhase.Text = "阶段"
        '
        'LocalMonth
        '
        Me.LocalMonth.Text = "年月"
        '
        'txtPhase
        '
        Me.txtPhase.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPhase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhase.Location = New System.Drawing.Point(256, 13)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.Size = New System.Drawing.Size(72, 22)
        Me.txtPhase.TabIndex = 13
        Me.txtPhase.Text = ""
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(337, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 23)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "选择企业"
        '
        'FImportFinance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(568, 469)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtPhase)
        Me.Controls.Add(Me.txtCorpName)
        Me.Controls.Add(Me.txtProCode)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.lblPhase)
        Me.Controls.Add(Me.lblProCode)
        Me.Controls.Add(Me.lblCorpName)
        Me.Controls.Add(Me.grpFrom)
        Me.Controls.Add(Me.grpTo)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.grpLocal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FImportFinance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "导入财务数据"
        Me.grpFrom.ResumeLayout(False)
        Me.grpTo.ResumeLayout(False)
        Me.grpLocal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal ProjectCode As String, ByVal Phase As String, ByVal CorpName As String)
        Me.New()

        Me._ProCode = ProjectCode
        Me._CorpCode = Me._ProCode.Substring(0, 5)
        Me._ToCorpCode = Me._ProCode.Substring(0, 5)
        Me._Phase = Phase
        Me._CorpName = CorpName
    End Sub

    Private _ProCode As String
    Private _Phase As String
    Private _CorpCode As String
    Private _CorpName As String
    Private _FromCorpCode As String
    Private _ToCorpCode As String

    '实现IComparer.Compare的类SortByCol
    Public Class SortByCol
        Implements IComparer

        Private col As Integer

        Public Sub New()
            col = 0
        End Sub
        Public Sub New(ByVal column As Integer)
            col = column
        End Sub

        '比较相应列的年月
        Public Overloads Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Return String.Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        End Function
    End Class

    Private Sub FImportFinance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProCode.Text = Me._ProCode
        Me.txtPhase.Text = Me._Phase
        Me.txtCorpName.Text = Me._CorpName
        AddHandler lvFrom.ColumnClick, AddressOf ColumnClick
        AddHandler lvTo.ColumnClick, AddressOf ColumnClick
        'Me.DataRefresh()
        Me.LocalDataRefresh()
        Me.btnImport.Enabled = False
        Me.btnMoveLeft.Enabled = False
    End Sub

    '数据刷新
    Private Sub DataRefresh()
        Me.lvFrom.Items.Clear()
        Me.lvTo.Items.Clear()
        Me.lvLocal.Items.Clear()
        Dim dsTemp As DataSet
        dsTemp = gWs.GetCommonQueryInfo("SELECT DISTINCT project_code,corporation_code, phase, month FROM corporation_account WHERE corporation_code = '" & Me._CorpCode & "' ORDER BY project_code,phase")
        Dim i As Integer
        For i = 0 To dsTemp.Tables(0).Rows.Count - 1
            With dsTemp.Tables(0).Rows(i)
                If CStr(.Item("project_code")) = Me._ProCode And CStr(.Item("phase")) = Me._Phase Then
                    Me.lvLocal.Items.Add(New ListViewItem(New String() {.Item("project_code"), .Item("phase"), .Item("month")}))
                Else
                    Me.lvFrom.Items.Add(New ListViewItem(New String() {.Item("project_code"), .Item("phase"), .Item("month")}))
                End If
            End With
        Next

        If Me.lvTo.Items.Count = 0 Then
            Me.btnImport.Enabled = False
            Me.btnMoveLeft.Enabled = False
        Else
            Me.btnImport.Enabled = True
            Me.btnMoveLeft.Enabled = True
        End If
        If Me.lvFrom.Items.Count = 0 Then
            Me.btnMoveRight.Enabled = False
        Else
            Me.btnMoveRight.Enabled = True
        End If
    End Sub

    Private Sub FromDataRefresh()
        Me.lvFrom.Items.Clear()
        Dim dsTemp As DataSet
        dsTemp = gWs.GetCommonQueryInfo("SELECT DISTINCT project_code,corporation_code, phase, month FROM corporation_account WHERE corporation_code = '" & Me._FromCorpCode & "' ORDER BY project_code,phase")
        Dim i As Integer
        For i = 0 To dsTemp.Tables(0).Rows.Count - 1
            With dsTemp.Tables(0).Rows(i)
                Me.lvFrom.Items.Add(New ListViewItem(New String() {.Item("project_code"), .Item("phase"), .Item("month")}))
            End With
        Next
    End Sub

    Private Sub LocalDataRefresh()
        Me.lvLocal.Items.Clear()
        Dim dsTemp As DataSet
        dsTemp = gWs.GetCommonQueryInfo("SELECT DISTINCT project_code,corporation_code, phase, month FROM corporation_account WHERE corporation_code = '" & Me._CorpCode & "' and project_code='" & Me._ProCode & "' ORDER BY project_code,phase")
        Dim i As Integer
        For i = 0 To dsTemp.Tables(0).Rows.Count - 1
            With dsTemp.Tables(0).Rows(i)
                Me.lvLocal.Items.Add(New ListViewItem(New String() {.Item("project_code"), .Item("phase"), .Item("month")}))
            End With
        Next
    End Sub

    '按列进行排序
    Private Sub ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)
        CType(sender, ListView).ListViewItemSorter = New SortByCol(e.Column)
        CType(sender, ListView).Sort()
    End Sub

    '如果导入的年月已经存在（本项目已经存在　或者　右边的导入列表已经存在）
    Private Function CheckData() As Boolean
        If Me.lvFrom.Items.Count = 0 Then
            Return False
        End If

        If Me.lvLocal.Items.Count = 0 Then '本项目该阶段的财务数据不存在，继续运行
            Return True
        End If

        If Me.lvFrom.SelectedIndices.Count = 0 Then '未有选定项
            If Me.lvFrom.FocusedItem Is Nothing Then '未有焦点项
                Me.lvFrom.Items(0).Selected = True
            Else
                Me.lvFrom.FocusedItem.Selected = True
            End If
        End If

        Dim strFrom As String
        strFrom = Me.lvFrom.SelectedItems(0).SubItems(2).Text

        Dim bSameMonth As Boolean '年月相同
        Dim lvItem As ListViewItem
        For Each lvItem In Me.lvLocal.Items
            If strFrom = lvItem.SubItems(2).Text Then
                If Not DialogResult.Yes = SWDialogBox.MessageBox.Show("年月已经存在，是否覆盖？", "系统提示", "", SWDialogBox.MessageBoxButton.YesNo, SWDialogBox.MessageBoxIcon.Question) Then
                    Return False '不覆盖，则操作不再继续
                End If
                bSameMonth = True
                Exit For
            End If
        Next

        For Each lvItem In Me.lvTo.Items
            If strFrom = lvItem.SubItems(2).Text Then '选择导入列表中的该年月已经存在，将导入列表中的相同项先移到左边
                Me.lvTo.Items.Remove(lvItem)
                Me.lvFrom.Items.Add(lvItem.Clone())
                Exit For
            End If
        Next

        Return True
    End Function

    '把选定项由一个ListView移往另一个ListView (note:本函数中使用的均为局部变量)
    Private Sub MoveFinanceDetail(ByVal lvFrom As ListView, ByVal lvTo As ListView)
        If lvFrom.Items.Count = 0 Then
            Return
        End If

        If lvFrom.SelectedIndices.Count = 0 Then '未有选定项
            If lvFrom.FocusedItem Is Nothing Then '未有焦点项
                lvFrom.Items(0).Selected = True
            Else
                lvFrom.FocusedItem.Selected = True
            End If
        End If

        Dim index As Integer = lvFrom.SelectedIndices(0)
        Dim lvItem As ListViewItem
        lvItem = lvFrom.SelectedItems(0)

        lvFrom.Items.Remove(lvItem)
        lvTo.Items.Add(lvItem.Clone())

        If Not lvFrom.Items.Count = 0 Then
            lvFrom.Items(IIf(index = lvFrom.Items.Count, index - 1, index)).Selected = True
        End If
        If Not lvTo.Items.Count = 0 Then
            lvTo.Items(lvTo.Items.Count - 1).Selected = True
        End If
    End Sub

    ''按右键或者双击左边的ListView----右移
    Private Sub btnMoveRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveRight.Click, lvFrom.DoubleClick
        If Not Me.CheckData() Then
            Return
        End If
        Me.MoveFinanceDetail(Me.lvFrom, Me.lvTo)
        If Not Me.lvTo.Items.Count = 0 Then
            Me.btnImport.Enabled = True
            Me.btnMoveLeft.Enabled = True
        End If
        If Me.lvFrom.Items.Count = 0 Then
            Me.btnMoveRight.Enabled = False
        End If
    End Sub

    '按左键或者双击右边的ListView----左移
    Private Sub btnMoveLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveLeft.Click, lvTo.DoubleClick
        Me.MoveFinanceDetail(Me.lvTo, Me.lvFrom)
        If Me.lvTo.Items.Count = 0 Then
            Me.btnImport.Enabled = False
            Me.btnMoveLeft.Enabled = False
        End If
        If Not Me.lvFrom.Items.Count = 0 Then
            Me.btnMoveRight.Enabled = True
        End If
    End Sub

    '导入
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim lvItem As ListViewItem
        Dim strResult As String
        For Each lvItem In Me.lvTo.Items
            '假设Phase为四个字符长，如果Phase产生变化，可以考虑增加到到
            strResult = gWs.ImportFinanceData(Me._FromCorpCode, lvItem.SubItems(0).Text, lvItem.SubItems(1).Text, lvItem.SubItems(2).Text, _ToCorpCode, _
                Me._ProCode, Me._Phase, UserName, gWs.GetSysTime(), True)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "导入失败", strResult, "")
                Return
            End If
        Next
        SWDialogBox.MessageBox.Show("$OperateSucceed")
        Me.LocalDataRefresh()
    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#Region "界面调整"
    Private Sub FImportFinance_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        Me.grpFrom.Width = (Me.ClientSize.Width - 72) / 2 '设定三个group的长度
        Me.grpTo.Width = Me.grpFrom.Width
        Me.grpLocal.Width = Me.grpTo.Width
        Me.grpFrom.Height = Me.btnImport.Location.Y - Me.grpFrom.Location.Y - 8
        Me.grpTo.Height = Me.grpLocal.Location.Y - Me.grpTo.Location.Y

        Me.btnMoveLeft.Left = Me.grpFrom.Left + Me.grpFrom.Width '设定中间两个button的位置
        Me.btnMoveRight.Left = Me.btnMoveLeft.Left

        Me.grpTo.Left = Me.btnMoveLeft.Left + Me.btnMoveLeft.Width '设定右边group的位置
        Me.grpLocal.Left = Me.grpTo.Left
    End Sub

    Private Sub FImportFinance_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim linePen As Drawing.Pen = New Drawing.Pen(Color.White)
        e.Graphics.DrawLine(linePen, Me.grpFrom.Left, Me.grpFrom.Top + 6, Me.grpTo.Left + Me.grpTo.Size.Width, Me.grpFrom.Top + 6)
        linePen.Color = Color.White
        e.Graphics.DrawLine(linePen, Me.grpFrom.Left, Me.grpFrom.Top + Me.grpFrom.Size.Height, Me.grpTo.Left + Me.grpTo.Size.Width, Me.grpFrom.Top + Me.grpFrom.Size.Height)
    End Sub
#End Region



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim objSearchCorporation As New frmSearchCorporation
        AddHandler objSearchCorporation.m_applyCallback, AddressOf GetSearchCorporationCode
        objSearchCorporation.ShowDialog()
    End Sub

    Private Sub GetSearchCorporationCode(ByVal CorporationCode As String)
        _FromCorpCode = CorporationCode
        FromDataRefresh()
    End Sub
End Class
