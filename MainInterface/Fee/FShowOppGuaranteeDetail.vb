Public Class FShowOppGuaranteeDetail
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
    End Sub

    Public Sub New(ByVal _ProjectCode As String, ByVal _SerialNum As Int32, ByVal _ItemType As String)
        Me.New()
        ProjectCode = _ProjectCode
        SerialNum = _SerialNum
        ItemType = _ItemType
    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsDetail Is Nothing Then
            dsDetail.Dispose()
        End If
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
    Friend WithEvents grdDetail As System.Windows.Forms.DataGrid
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents style As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_ItemName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_item_value As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FShowOppGuaranteeDetail))
        Me.grdDetail = New System.Windows.Forms.DataGrid()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.style = New System.Windows.Forms.DataGridTableStyle()
        Me.col_ItemName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col_item_value = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdDetail
        '
        Me.grdDetail.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdDetail.CaptionVisible = False
        Me.grdDetail.DataMember = ""
        Me.grdDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDetail.Location = New System.Drawing.Point(8, 8)
        Me.grdDetail.Name = "grdDetail"
        Me.grdDetail.ReadOnly = True
        Me.grdDetail.Size = New System.Drawing.Size(320, 248)
        Me.grdDetail.TabIndex = 0
        Me.grdDetail.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.style})
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(120, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'style
        '
        Me.style.DataGrid = Me.grdDetail
        Me.style.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_ItemName, Me.col_item_value})
        Me.style.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.style.MappingName = "opposite_guarantee_detail"
        '
        'col_ItemName
        '
        Me.col_ItemName.Format = ""
        Me.col_ItemName.FormatInfo = Nothing
        Me.col_ItemName.HeaderText = "内容"
        Me.col_ItemName.MappingName = "ItemName"
        Me.col_ItemName.NullText = ""
        Me.col_ItemName.Width = 150
        '
        'col_item_value
        '
        Me.col_item_value.Format = ""
        Me.col_item_value.FormatInfo = Nothing
        Me.col_item_value.HeaderText = "值"
        Me.col_item_value.MappingName = "item_value"
        Me.col_item_value.NullText = ""
        '
        'FShowOppGuaranteeDetail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(336, 293)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.grdDetail})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FShowOppGuaranteeDetail"
        Me.Text = "反担保物详细信息"
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ProjectCode As String
    Private SerialNum As Int32
    Private ItemType As String
    Private dsDetail As DataSet

    Private Sub FShowOppGuaranteeDetail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            dsDetail = gWs.GetGuarantyInfo("null", "{project_code='" & ProjectCode & "' AND serial_num=" & SerialNum.ToString & "}")
            dsDetail.Tables("opposite_guarantee_detail").Columns.Add("ItemName", GetType(String))
            Dim row As DataRow
            Dim rows() As DataRow
            Dim dsItem As DataSet = gWs.GetItem("%", ItemType)
            'Me.Text += "(" & dsItem.Tables("TItemType").Rows(0)("type_name") & ")"
            For Each row In dsDetail.Tables("opposite_guarantee_detail").Rows
                rows = dsItem.Tables("TItem").Select("item_type='" & row("item_type") & "' AND item_code='" & row("item_code") & "'")
                If rows.Length > 0 Then
                    row("ItemName") = rows(0)("item_name")
                Else
                    row("ItemName") = "未知"
                End If
            Next
            dsItem.Dispose()
            grdDetail.SetDataBinding(dsDetail, "opposite_guarantee_detail")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
