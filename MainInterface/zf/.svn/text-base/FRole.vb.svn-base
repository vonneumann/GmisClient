Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FRole
	Inherits FBaseData

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
	Friend csNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend csName As System.Windows.Forms.DataGridTextBoxColumn
	Friend tsRole As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csIsConsign As System.Windows.Forms.DataGridBoolColumn

	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRole))
        Me.tsRole = New System.Windows.Forms.DataGridTableStyle()
        Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIsConsign = New System.Windows.Forms.DataGridBoolColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsRole})
        Me.grdTable.Visible = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Visible = True
        '
        'tsRole
        '
        Me.tsRole.DataGrid = Me.grdTable
        Me.tsRole.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName, Me.csIsConsign})
        Me.tsRole.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsRole.MappingName = "TRole"
        '
        'csNo
        '
        Me.csNo.Format = ""
        Me.csNo.FormatInfo = Nothing
        Me.csNo.HeaderText = "编  号"
        Me.csNo.MappingName = "role_id"
        Me.csNo.ReadOnly = True
        Me.csNo.Width = 75
        '
        'csName
        '
        Me.csName.Format = ""
        Me.csName.FormatInfo = Nothing
        Me.csName.HeaderText = "角色名称"
        Me.csName.MappingName = "role_name"
        Me.csName.Width = 210
        '
        'csIsConsign
        '
        Me.csIsConsign.FalseValue = False
        Me.csIsConsign.HeaderText = "可否委托"
        Me.csIsConsign.MappingName = "isConsign"
        Me.csIsConsign.NullValue = CType(resources.GetObject("csIsConsign.NullValue"), System.DBNull)
        Me.csIsConsign.TrueValue = True
        Me.csIsConsign.Width = 75
        '
        'FRole
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Name = "FRole"
        Me.Text = "角色设置"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private cm As CurrencyManager = Nothing

    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsResult As DataSet

            dsResult = gWs.GetRole("%")
            grdTable.SetDataBinding(dsResult, "TRole")

            cm = Me.BindingContext(grdTable.DataSource, grdTable.DataMember)
            AddHandler cm.PositionChanged, AddressOf PositionChanged
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)

            If dsCommit Is Nothing OrElse (Not dsCommit.HasChanges()) Then
                Return False
            End If

            Dim result As String = gWs.UpdateRole(dsCommit.GetChanges())

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
