

Public Class frmOppGuaranteeQuery
    Inherits MainInterface.frmOppGuarantee

    Private strProjectCode As String = "P001"
    Private strCorporationName As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strPerson As String

    Private strDir As String = "\Document\Image\" '图片保存的目录
    Private dsOppGuaranteeView As DataSet '显示
    Private dsDetailView As DataSet '显示
    Private isByNew As Boolean '是否通过实例new(projectCode,corporationName).是，则设为true

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    Public Sub New(ByVal projectCode As String, ByVal corporationName As String)
        Me.New()
        Me.strProjectCode = projectCode
        Me.strCorporationName = corporationName
        isByNew = True
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
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOppGuaranteeQuery))
        Me.btnView = New System.Windows.Forms.Button()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(256, 24)
        Me.Label6.Visible = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(456, 80)
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.Text = "担保额(元)"
        Me.Label7.Visible = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label13})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 352)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.Visible = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(456, 24)
        Me.Label11.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Location = New System.Drawing.Point(408, 40)
        Me.GroupBox3.Size = New System.Drawing.Size(296, 304)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.Visible = True
        '
        'Label10
        '
        Me.Label10.Visible = True
        '
        'txtRemark
        '
        Me.txtRemark.Size = New System.Drawing.Size(354, 21)
        Me.txtRemark.TabIndex = 3
        Me.txtRemark.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Size = New System.Drawing.Size(392, 304)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.Visible = True
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.AccessibleName = "DataGrid"
        Me.dgOppGuarantee.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgOppGuarantee.ReadOnly = True
        Me.dgOppGuarantee.Size = New System.Drawing.Size(386, 284)
        Me.dgOppGuarantee.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dgOppGuarantee.Visible = True
        '
        'dateEvaluate
        '
        Me.dateEvaluate.Location = New System.Drawing.Point(520, 53)
        Me.dateEvaluate.Size = New System.Drawing.Size(168, 21)
        Me.dateEvaluate.TabIndex = 4
        Me.dateEvaluate.Value = New Date(2003, 4, 2, 16, 56, 35, 859)
        Me.dateEvaluate.Visible = True
        '
        'cmbType
        '
        Me.cmbType.DropDownWidth = 176
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Size = New System.Drawing.Size(176, 20)
        Me.cmbType.TabIndex = 0
        Me.cmbType.Visible = True
        '
        'txtContract
        '
        Me.txtContract.Location = New System.Drawing.Point(520, 25)
        Me.txtContract.Size = New System.Drawing.Size(168, 21)
        Me.txtContract.TabIndex = 2
        Me.txtContract.Visible = True
        '
        'txtGuarantee
        '
        Me.txtGuarantee.Location = New System.Drawing.Point(520, 80)
        Me.txtGuarantee.Size = New System.Drawing.Size(168, 21)
        Me.txtGuarantee.TabIndex = 7
        Me.txtGuarantee.Visible = True
        '
        'cmbMeasure
        '
        Me.cmbMeasure.ItemHeight = 12
        Me.cmbMeasure.Location = New System.Drawing.Point(326, 25)
        Me.cmbMeasure.TabIndex = 1
        Me.cmbMeasure.Visible = True
        '
        'txtEvaluate
        '
        Me.txtEvaluate.Location = New System.Drawing.Point(326, 81)
        Me.txtEvaluate.TabIndex = 6
        Me.txtEvaluate.Visible = True
        '
        'Label3
        '
        Me.Label3.Visible = True
        '
        'Label4
        '
        Me.Label4.Text = "原值(元)"
        Me.Label4.Visible = True
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'dgDetail
        '
        Me.dgDetail.AccessibleName = "DataGrid"
        Me.dgDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgDetail.ReadOnly = True
        Me.dgDetail.Size = New System.Drawing.Size(290, 284)
        Me.dgDetail.Visible = True
        '
        'txtOriginal
        '
        Me.txtOriginal.TabIndex = 5
        Me.txtOriginal.Visible = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(256, 80)
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.Text = "评估值(元)"
        Me.Label5.Visible = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(456, 52)
        Me.Label9.Visible = True
        '
        'txtName
        '
        Me.txtName.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(371, 472)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Visible = True
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Bitmap)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 17
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(266, 472)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "浏览图片(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AllowSorting = False
        Me.DataGridTableStyle2.DataGrid = Me.dgOppGuarantee
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "opposite_guarantee"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "类型"
        Me.DataGridTextBoxColumn3.MappingName = "type_name"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "原值(元)"
        Me.DataGridTextBoxColumn4.MappingName = "original_value"
        Me.DataGridTextBoxColumn4.NullText = "0"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "评估值(元)"
        Me.DataGridTextBoxColumn5.MappingName = "evaluate_value"
        Me.DataGridTextBoxColumn5.NullText = "0"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "担保额(元)"
        Me.DataGridTextBoxColumn6.MappingName = "guarantee_value"
        Me.DataGridTextBoxColumn6.NullText = "0"
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "备注"
        Me.DataGridTextBoxColumn7.MappingName = "remark"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 150
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(640, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 23)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "元"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmOppGuaranteeQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 503)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtName, Me.GroupBox4, Me.btnExit, Me.GroupBox3, Me.GroupBox2, Me.btnView})
        Me.Name = "frmOppGuaranteeQuery"
        Me.Text = "反担保物查询"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Load()
    Private Sub frmOppGuaranteeQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not isByNew Then
            Me.strProjectCode = Me.getProjectCode()
            Me.strCorporationName = Me.getCorporationName()
        End If
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser
        Try
            Me.dateEvaluate.Value = gWs.GetSysTime()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName

        dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode, "0")
        If Not dsOppGuaranteeView Is Nothing Then
            Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
        End If
        setTextBox(False)
        If Not dsOppGuaranteeView Is Nothing Then
            Me.dsOppGuaranteeView.AcceptChanges()
        End If
        If Not dsDetailView Is Nothing Then
            Me.dsDetailView.AcceptChanges()
        End If
        getDetail()
        setButton()
    End Sub
    '
    '获得反担保物的详细信息
    '
    Private Sub getDetail()
        Dim index As Integer
        Dim strCode, strSerial, strType, strState As String
        index = Me.dgOppGuarantee.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        Try
            strCode = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("project_code")
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerial = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("serial_num")
            If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("guaranty_type") Is System.DBNull.Value Then
                strType = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("guaranty_type")
            End If
            If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("status") Is System.DBNull.Value Then
                strState = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("status")
            End If
            dsDetailView = getOppGuaranteeDetail(strCode, strSerial, strType)
            Me.dgDetail.DataSource = dsDetailView.Tables("opposite_guarantee_detail")
        Else
            dsDetailView.Tables("opposite_guarantee_detail").Clear()
        End If
    End Sub
    '设置"浏览图片"按钮的Enabled属性
    Private Sub setButton()
        Dim dt As DataTable
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
            If dt.Rows.Count > 0 Then
                ' qxd modify 2004-8-17
                If IsAllowViewPicture() Then
                    Me.btnView.Enabled = True
                Else
                    Me.btnView.Enabled = False
                End If
                'If dt.Rows(Me.dgOppGuarantee.CurrentRowIndex).Item("file_relation_num") Is System.DBNull.Value Then
                '    Me.btnView.Enabled = False
                'Else
                '    Me.btnView.Enabled = True
                'End If
            Else
                Me.btnView.Enabled = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '设置反担保物信息
    '
    Private Sub getOppGuaranteeInfo()
        Dim index As Integer
        Dim dt As DataTable
        index = Me.dgOppGuarantee.CurrentRowIndex
        dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
        If index < 0 Then
            Exit Sub
        End If
        Try
            With dt.Rows(index)
                If Not .Item("original_value") Is System.DBNull.Value Then
                    Me.txtOriginal.Text = .Item("original_value")
                Else
                    Me.txtOriginal.Text = ""
                End If
                If Not .Item("evaluate_value") Is System.DBNull.Value Then
                    Me.txtEvaluate.Text = .Item("evaluate_value")
                Else
                    Me.txtEvaluate.Text = ""
                End If
                If Not .Item("guarantee_value") Is System.DBNull.Value Then
                    Me.txtGuarantee.Text = .Item("guarantee_value")
                Else
                    Me.txtGuarantee.Text = ""
                End If
                If Not .Item("evaluate_date") Is System.DBNull.Value Then
                    Me.dateEvaluate.Value = .Item("evaluate_date")
                Else
                    Try
                        Me.dateEvaluate.Value = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
                If Not .Item("contract_no") Is System.DBNull.Value Then
                    Me.txtContract.Text = .Item("contract_no")
                Else
                    Me.txtContract.Text = ""
                End If
                If Not .Item("remark") Is System.DBNull.Value Then
                    Me.txtRemark.Text = .Item("remark")
                Else
                    Me.txtRemark.Text = ""
                End If
                If Not .Item("guaranty_type") Is System.DBNull.Value Then
                    Me.cmbType.Text = getGuaranteeType(.Item("guaranty_type"))
                End If
                If Not .Item("opposite_guarantee_form") Is System.DBNull.Value Then
                    Me.cmbMeasure.Text = getGuaranteeForm(.Item("opposite_guarantee_form"))
                End If
            End With
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '浏览图片
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim ds As DataSet
        Dim strCode As String
        Dim strRelationNum As String
        Dim strItemType As String
        Dim index As Integer
        index = Me.dgOppGuarantee.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        ds = dsOppGuaranteeView
        If Not ds.Tables("opposite_guarantee").Rows(index).Item("project_code") Is System.DBNull.Value Then
            strCode = ds.Tables("opposite_guarantee").Rows(index).Item("project_code")
        End If
        If Not ds.Tables("opposite_guarantee").Rows(index).Item("guaranty_type") Is System.DBNull.Value Then
            strItemType = ds.Tables("opposite_guarantee").Rows(index).Item("guaranty_type")
        End If
        'qxd modify 2004-8-17
        'If Not ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num") Is System.DBNull.Value Then
        '    strRelationNum = ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num")
        '    Me.Cursor = Cursors.WaitCursor
        '    Dim docClass As New frmDocumentClass("")
        '    'docClass.openFileList(strProjectCode, strItemType, "", strDir)
        '    docClass.openFileList(strProjectCode, "2%", "", strDir)
        '    Me.Cursor = Cursors.Default
        'Else
        '    'MsgBox("没有相关的图片!", MsgBoxStyle.Exclamation, "提示")
        '    SWDialogBox.MessageBox.Show("$1005", "图片")
        'End If
        Me.Cursor = Cursors.WaitCursor
        Dim docClass As New frmDocumentClass("")
        'docClass.openFileList(strProjectCode, strItemType, "", strDir)
        docClass.openFileList(strProjectCode, "2%", "", strDir)
        Me.Cursor = Cursors.Default
    End Sub
    '设置TextBox的Enabled属性
    Private Sub setTextBox(ByVal isEnabled As Boolean)
        Me.txtOriginal.Enabled = isEnabled
        Me.txtGuarantee.Enabled = isEnabled
        Me.txtEvaluate.Enabled = isEnabled
        Me.txtContract.Enabled = isEnabled
        Me.cmbType.Enabled = isEnabled
        Me.dateEvaluate.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
        Me.cmbMeasure.Enabled = isEnabled
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'KeyPress()
    Private Sub frmOppGuaranteeQuery_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    '列表中鼠标按下事件
    Private Sub dgOppGuarantee_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOppGuarantee.MouseUp
        If Me.dsOppGuaranteeView Is Nothing Then
            Exit Sub
        End If
        If Me.dsOppGuaranteeView.Tables("opposite_guarantee").Rows.Count > 0 Then
            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
            setButton()
            getDetail()
            getOppGuaranteeInfo()
            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
        End If
    End Sub

    '
    '如果项目其中的一个反担保物有图片，则查看按钮可用。
    'qxd add 2004－8－17 
    '目的：为了省去查看时，需要选择具体一个反担保物有图片时才允许查看图片的麻烦！
    Private Function IsAllowViewPicture()
        Dim dt As DataTable
        Dim dr As DataRow
        Dim i, count As Integer
        Dim flag As Boolean = False
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)

            If Not dt Is Nothing Then
                count = dt.Rows.Count
                If count > 0 Then
                    For i = 0 To count - 1
                        If Not dt.Rows(i).Item("file_relation_num") Is System.DBNull.Value Then
                            flag = True
                            Exit For
                        End If
                    Next
                End If
            End If
            Return flag
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
End Class
