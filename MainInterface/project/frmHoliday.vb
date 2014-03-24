Public Class frmHoliday
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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dgHoliday As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cHoliday As SWCalendar.MyCalendar
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHoliday))
        Me.dgHoliday = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cHoliday = New SWCalendar.MyCalendar()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.dgHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgHoliday
        '
        Me.dgHoliday.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)
        Me.dgHoliday.CaptionVisible = False
        Me.dgHoliday.DataMember = ""
        Me.dgHoliday.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgHoliday.Location = New System.Drawing.Point(8, 8)
        Me.dgHoliday.Name = "dgHoliday"
        Me.dgHoliday.Size = New System.Drawing.Size(344, 166)
        Me.dgHoliday.TabIndex = 1
        Me.dgHoliday.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgHoliday
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "holiday"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "节假日"
        Me.DataGridTextBoxColumn1.MappingName = "holiday"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 110
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "备注"
        Me.DataGridTextBoxColumn2.MappingName = "remark"
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 3
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(267, 360)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 1
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(97, 360)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdd.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Bitmap)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageIndex = 0
        Me.btnAdd.ImageList = Me.ImageList1
        Me.btnAdd.Location = New System.Drawing.Point(12, 360)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "新 增(&N)"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.ImageIndex = 2
        Me.btnUpdate.ImageList = Me.ImageList1
        Me.btnUpdate.Location = New System.Drawing.Point(182, 360)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(77, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "保 存(&S)"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cHoliday
        '
        Me.cHoliday.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cHoliday.Location = New System.Drawing.Point(20, 184)
        Me.cHoliday.Name = "cHoliday"
        Me.cHoliday.Size = New System.Drawing.Size(317, 168)
        Me.cHoliday.TabIndex = 14
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmHoliday
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(360, 389)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cHoliday, Me.btnExit, Me.btnDelete, Me.btnAdd, Me.btnUpdate, Me.dgHoliday})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHoliday"
        Me.Text = "节假日设置"
        CType(Me.dgHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsHoliday As DataSet
    Private iYear As Integer

    Private Sub frmHoliday_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '获取系统日期
        Dim sysDate As DateTime = gWs.GetSysTime()

        '获取系统年份
        iYear = Year(sysDate)

        '获取当前年份的节假日列表
        dsHoliday = getHolidayList(iYear)

        '在日历控件中填充节假日列表
        fillHolidayList()

        dgHoliday.DataSource = dsHoliday.Tables(0)

        '设置网格不能新增和删除
        setDgDeleteAttribute(dgHoliday, Me)
        setDgAttribute(dgHoliday, Me)
    End Sub

    '添加节假日按钮事件
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        '判断该节假日是否已添加
        If Me.cHoliday.ColorDates.IndexOf(cHoliday.SelectedDate.ToString("yyyy-MM-dd")) < 0 Then
       

            Me.cHoliday.AddColorDate(cHoliday.SelectedDate())
            Me.cHoliday.UpdateColorDates()

            '添加节假日到节假日日表中
            Dim newRow As DataRow = dsHoliday.Tables(0).NewRow
            newRow.Item("holiday") = cHoliday.SelectedDate()
            newRow.Item("scaned") = 0
            dsHoliday.Tables(0).Rows.Add(newRow)

        Else

            MsgBox("该节假日已设置", MsgBoxStyle.Information, "节假日设置")

        End If

    End Sub

    '获取某年的节假日列表
    Private Function getHolidayList(ByVal iYear As Integer) As DataSet
        Dim strSql As String
        '获取当年的所有节假日数据集
        strSql = "{year(holiday)=" & iYear & "}"
        Return gWs.GetHolidayInfo(strSql)
    End Function

    '填充节假日列表
    Private Function fillHolidayList()
        Dim i As Integer
        For i = 0 To dsHoliday.Tables(0).Rows.Count - 1
            Me.cHoliday.AddColorDate(dsHoliday.Tables(0).Rows(i).Item("holiday"))
        Next
        Me.cHoliday.UpdateColorDates()
    End Function

    '保存节假日按钮事件
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        '调用UpdateHoliday方法保存节假日设置
        Dim strErr As String = gWs.UpdateHoliday(dsHoliday)
        dsHoliday.AcceptChanges()
        If strErr <> "1" Then
            MessageBox.Show("系统返回信息：" + strErr, "节假日设置", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    '日历控件的日期改变事件
    Private Sub cHoliday_DateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cHoliday.DateChanged


        '判断所选年份是否与当前年份相同,如果不同重新获取该年节假日列表
        If cHoliday.SelectedDate.Year <> cHoliday.OldSelectedDate.Year Then
            dsHoliday = getHolidayList(cHoliday.SelectedDate.Year)
            fillHolidayList()
            dgHoliday.DataSource = dsHoliday.Tables(0)
        End If


    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '删除节假日按钮事件
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        '判断所选日期是否为节假日
        If Me.cHoliday.ColorDates.IndexOf(cHoliday.SelectedDate.ToString("yyyy-MM-dd")) >= 0 Then

            Me.cHoliday.DeleteColorDate(cHoliday.SelectedDate())
            Me.cHoliday.UpdateColorDates()

            '删除节假日
            Dim strSql As String
            Dim i As Integer
            strSql = "holiday=" & "'" & cHoliday.SelectedDate().ToString & "'"
            Dim dr() As DataRow = dsHoliday.Tables(0).Select(strSql)
            For i = 0 To dr.Length - 1
                dr(i).Delete()
            Next

        End If
    End Sub

    '窗体关闭事件
    Private Sub frmHoliday_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        '判断数据是否被改动过
        If dsHoliday.GetChanges Is Nothing Then
            Return
        End If

        '如果有，提交改变的数据，并保存
        Dim result As DialogResult = MessageBox.Show("资料已经被改动过，您要保存吗？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim strErr As String = gWs.UpdateHoliday(dsHoliday)
            If strErr <> "1" Then
                MessageBox.Show("系统返回信息：" + strErr, "节假日设置", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            If result = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If

    End Sub
End Class
