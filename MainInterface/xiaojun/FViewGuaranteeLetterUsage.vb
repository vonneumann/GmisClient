
'查看额度协议信息
Public Class FViewGuaranteeLetterUsage
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    Public Sub New(ByVal project_code As String)
        Me.New()

        strProjectCode = project_code
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
    Friend WithEvents grdUsage As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents col2_1 As DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FViewGuaranteeLetterUsage))
        Me.grdUsage = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button
        Me.col2_1 = New DataGridTextBoxColumn
        CType(Me.grdUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdUsage
        '
        Me.grdUsage.CaptionVisible = False
        Me.grdUsage.DataMember = ""
        Me.grdUsage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdUsage.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdUsage.Location = New System.Drawing.Point(3, 17)
        Me.grdUsage.Name = "grdUsage"
        Me.grdUsage.ReadOnly = True
        Me.grdUsage.Size = New System.Drawing.Size(554, 292)
        Me.grdUsage.TabIndex = 1
        Me.grdUsage.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})


        col2_1.MappingName = "term"     '期限
        col2_1.HeaderText = "期限(月)"
        col2_1.TextBox.MaxLength = 18
        col2_1.NullText = String.Empty
        col2_1.Width = 75

        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdUsage
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.col2_1, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TGuaranteeLetterUsage"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "保函种类"
        Me.DataGridTextBoxColumn1.MappingName = "letter_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "偿付责任类型"
        Me.DataGridTextBoxColumn2.MappingName = "Reimburse_name"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 120

        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "保证金比例(%)"
        Me.DataGridTextBoxColumn3.MappingName = "guarantee_scale"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 85
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "担保费率(%)"
        Me.DataGridTextBoxColumn4.MappingName = "guarantee_rate"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "创建人"
        Me.DataGridTextBoxColumn5.MappingName = "create_person"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "创建时间"
        Me.DataGridTextBoxColumn6.MappingName = "create_date"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdUsage})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 312)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "额度协议"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(488, 328)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FViewGuaranteeLetterUsage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(578, 359)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FViewGuaranteeLetterUsage"
        Me.Text = "协议信息"
        CType(Me.grdUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsTemp As DataSet
    Private strProjectCode As String '项目编码

    Private Sub FViewGuaranteeLetterUsage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.GetData()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GetData()
        Dim CorpCode As String
        Dim applyDate As DateTime
        dsTemp = gWs.GetProjectInfo("{project_code='" & Me.strProjectCode & "'}")
        If dsTemp.Tables("project").Rows.Count = 0 Then
            Return
        End If
        CorpCode = dsTemp.Tables("project").Rows(0).Item("corporation_code")
        applyDate = dsTemp.Tables("project").Rows(0).Item("apply_date")         '不可能为空
        dsTemp.Merge(gWs.GetGuaranteeLetter(CorpCode, applyDate))
        If Not dsTemp.Tables("TGuaranteeLetter").Rows.Count = 0 Then
            Dim project_code As String         '先从GuaranteeLetter中取得project_code
            If Not dsTemp.Tables("TGuaranteeLetter").Rows(0).Item("project_code") Is DBNull.Value Then
                project_code = dsTemp.Tables("TGuaranteeLetter").Rows(0).Item("project_code")
                If Not project_code = "" Then
                    Try
                        dsTemp.Merge(gWs.GetGuaranteeLetterUsage("{project_code ='" & project_code & "'}").Tables("TGuaranteeLetterUsage"))
                        dsTemp.Merge(gWs.GetGuaranteeLetterType("%").Tables("TGuaranteeLetterType"))
                        dsTemp.Relations.Add("RLetterType", dsTemp.Tables("TGuaranteeLetterType").Columns("type_code"), dsTemp.Tables("TGuaranteeLetterUsage").Columns("guarantee_letter_type"))
                        dsTemp.Tables("TGuaranteeLetterUsage").Columns.Add("letter_name", GetType(String), "parent(RLetterType).name")
                        dsTemp.Merge(gWs.GetReimburseType("%").Tables("TReimburseType"))
                        dsTemp.Relations.Add("RReimburseType", dsTemp.Tables("TReimburseType").Columns("type_code"), dsTemp.Tables("TGuaranteeLetterUsage").Columns("reimburse_type"))
                        dsTemp.Tables("TGuaranteeLetterUsage").Columns.Add("Reimburse_name", GetType(String), "parent(RReimburseType).name")
                        Me.grdUsage.DataSource = dsTemp.Tables("TGuaranteeLetterUsage")
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
