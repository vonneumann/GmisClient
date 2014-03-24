Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FCreditAppraiseSystem
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
	Friend csUsed As System.Windows.Forms.DataGridBoolColumn
	Friend csDate As System.Windows.Forms.DataGridTextBoxColumn
	Friend csRemark As System.Windows.Forms.DataGridTextBoxColumn
	Friend csQuantitive As System.Windows.Forms.DataGridTextBoxColumn
	Friend csQualitive As System.Windows.Forms.DataGridTextBoxColumn
	Friend tsCreditAppraiseSystem As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents btnDuplicate As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FCreditAppraiseSystem))
        Me.tsCreditAppraiseSystem = New System.Windows.Forms.DataGridTableStyle()
        Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csQuantitive = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csQualitive = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csUsed = New System.Windows.Forms.DataGridBoolColumn()
        Me.csDate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRemark = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnDuplicate = New System.Windows.Forms.Button()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(396, 302)
        Me.btnExit.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.Location = New System.Drawing.Point(220, 302)
        Me.btnDelete.Visible = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.Location = New System.Drawing.Point(308, 302)
        Me.btnUpdate.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Location = New System.Drawing.Point(132, 302)
        Me.btnRefresh.Visible = True
        '
        'tsCreditAppraiseSystem
        '
        Me.tsCreditAppraiseSystem.DataGrid = Me.grdTable
        Me.tsCreditAppraiseSystem.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csQuantitive, Me.csQualitive, Me.csUsed, Me.csDate, Me.csRemark})
        Me.tsCreditAppraiseSystem.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsCreditAppraiseSystem.MappingName = "TCreditAppraiseSystem"
        '
        'csNo
        '
        Me.csNo.Format = ""
        Me.csNo.FormatInfo = Nothing
        Me.csNo.HeaderText = "编  号"
        Me.csNo.MappingName = "system_id"
        Me.csNo.Width = 60
        '
        'csQuantitive
        '
        Me.csQuantitive.Format = ""
        Me.csQuantitive.FormatInfo = Nothing
        Me.csQuantitive.HeaderText = "定量比例"
        Me.csQuantitive.MappingName = "quantitive_score_proportion"
        Me.csQuantitive.Width = 60
        '
        'csQualitive
        '
        Me.csQualitive.Format = ""
        Me.csQualitive.FormatInfo = Nothing
        Me.csQualitive.HeaderText = "定性比例"
        Me.csQualitive.MappingName = "qualitive_score_proportion"
        Me.csQualitive.Width = 60
        '
        'csUsed
        '
        Me.csUsed.FalseValue = False
        Me.csUsed.HeaderText = "使用标志"
        Me.csUsed.MappingName = "used_flag"
        Me.csUsed.NullValue = CType(resources.GetObject("csUsed.NullValue"), System.DBNull)
        Me.csUsed.TrueValue = True
        Me.csUsed.Width = 60
        '
        'csDate
        '
        Me.csDate.Format = "D"
        Me.csDate.FormatInfo = Nothing
        Me.csDate.HeaderText = "启用日期"
        Me.csDate.MappingName = "used_from"
        Me.csDate.Width = 75
        '
        'csRemark
        '
        Me.csRemark.Format = ""
        Me.csRemark.FormatInfo = Nothing
        Me.csRemark.HeaderText = "备    注"
        Me.csRemark.MappingName = "remark"
        Me.csRemark.Width = 300
        '
        'btnDuplicate
        '
        Me.btnDuplicate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDuplicate.Image = CType(resources.GetObject("btnDuplicate.Image"), System.Drawing.Bitmap)
        Me.btnDuplicate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDuplicate.ImageIndex = 4
        Me.btnDuplicate.ImageList = Me.ImageList1
        Me.btnDuplicate.Location = New System.Drawing.Point(44, 302)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Size = New System.Drawing.Size(77, 23)
        Me.btnDuplicate.TabIndex = 10
        Me.btnDuplicate.Text = "复 制(&C)"
        Me.btnDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FCreditAppraiseSystem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable, Me.btnDuplicate})
        Me.Name = "FCreditAppraiseSystem"
        Me.Text = "资信评分体系设置"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.FetchCreditAppraiseSystem("%")
			grdTable.SetDataBinding(dsResult, "TCreditAppraiseSystem")
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

            Dim result As String = gWs.UpdateCreditAppraiseSystem(dsCommit.GetChanges())

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

	Private Sub FBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		grdTable.TableStyles.Add(Me.tsCreditAppraiseSystem)
	End Sub

    Private Sub btnDuplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplicate.Click
        Dim cm As CurrencyManager = Me.BindingContext(grdTable.DataSource, grdTable.DataMember)

        Dim rv As DataRowView = CType(cm.Current, DataRowView)

        If Not rv Is Nothing Then
            gWs.DuplicateCreditAppraise(rv("system_id"))
            Me.Refresh()
        End If
    End Sub
End Class
