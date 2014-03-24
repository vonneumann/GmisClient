Public Class FLoanChargeManner
    Inherits FBaseData

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        Me.csName.TextBox.MaxLength = 30
        Me.csNo.TextBox.MaxLength = 2
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
    Friend WithEvents tsLoadChargeManner As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csName As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FLoanChargeManner))
        Me.tsLoadChargeManner = New System.Windows.Forms.DataGridTableStyle()
        Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsLoadChargeManner})
        Me.grdTable.Visible = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.ImageIndex = -1
        Me.btnUpdate.ImageList = Nothing
        Me.btnUpdate.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Visible = True
        '
        'tsLoadChargeManner
        '
        Me.tsLoadChargeManner.DataGrid = Me.grdTable
        Me.tsLoadChargeManner.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName})
        Me.tsLoadChargeManner.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsLoadChargeManner.MappingName = "TLoanChargeManner"
        '
        'csNo
        '
        Me.csNo.Format = ""
        Me.csNo.FormatInfo = Nothing
        Me.csNo.HeaderText = "编  号"
        Me.csNo.MappingName = "loan_charge_manner_code"
        Me.csNo.NullText = ""
        Me.csNo.ReadOnly = True
        Me.csNo.Width = 75
        '
        'csName
        '
        Me.csName.Format = ""
        Me.csName.FormatInfo = Nothing
        Me.csName.HeaderText = "收费方式"
        Me.csName.MappingName = "loan_charge_manner"
        Me.csName.NullText = ""
        Me.csName.Width = 75
        '
        'FLoanChargeManner
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Name = "FLoanChargeManner"
        Me.Text = "项目收费方式设置"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '2006-4-21
    '---------Design By zhoufucai
    Private cm As CurrencyManager = Nothing

    '重写基类的装载函数
    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsResult As DataSet

            dsResult = gWs.GetLoanChargeManner("%")
            grdTable.SetDataBinding(dsResult, "TLoanChargeManner")

            cm = Me.BindingContext(grdTable.DataSource, grdTable.DataMember)
            AddHandler cm.PositionChanged, AddressOf PositionChanged
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '
    Private Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("loan_charge_manner_code IS NULL OR loan_charge_manner_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "编号")
            Return False
        End If
        If data.Select("loan_charge_manner IS NULL OR loan_charge_manner=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "放款方式")
            Return False
        End If
        Dim i, j, count As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)
        count = rows.Length
        For i = 0 To count - 1
            For j = i + 1 To count - 1
                If rows(i)("loan_charge_manner") = rows(j)("loan_charge_manner") Then
                    SWDialogBox.MessageBox.Show("$1003", "放款方式")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    '修改
    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)

            If dsCommit Is Nothing OrElse (Not dsCommit.HasChanges()) Then
                Return False
            End If

            If Not ValidateMaster(dsCommit.Tables(0)) Then
                Return False
            End If

            Dim result As String = gWs.UpdateLoanChargeManner(dsCommit.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsCommit.AcceptChanges()

                Return True
            Else
                '显示服务器的返回错误信息
                SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
            End If
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return False
    End Function

    Private Sub PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Not cm Is Nothing Then
            Dim rv As DataRowView = CType(cm.Current, DataRowView)

            csNo.ReadOnly = Not rv.IsNew
        End If
    End Sub

End Class
