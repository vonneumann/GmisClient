

Public Class frmOppGuaranteeQueryCheck
    Inherits MainInterface.frmOppGuarantee

    Private strProjectCode As String
    Private strCorporationName As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strPerson As String

    Private strDir As String = "\Document\Image\" '图片保存的目录
    Private dsOppGuaranteeView As DataSet
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn '显示
    Private dsDetailView As DataSet '显示


#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    Public Sub New(ByVal ProjectCode As String)
        Me.New()
        Me.strProjectCode = ProjectCode
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

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOppGuaranteeQueryCheck))
        Me.btnView = New System.Windows.Forms.Button
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEvaluateNet
        '
        Me.txtEvaluateNet.Location = New System.Drawing.Point(432, 76)
        Me.txtEvaluateNet.Size = New System.Drawing.Size(75, 21)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox2.Size = New System.Drawing.Size(328, 304)
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(344, 32)
        Me.GroupBox3.Size = New System.Drawing.Size(352, 304)
        '
        'cmbType
        '
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Location = New System.Drawing.Point(72, 22)
        '
        'txtOriginal
        '
        Me.txtOriginal.Location = New System.Drawing.Point(70, 74)
        '
        'txtEvaluate
        '
        Me.txtEvaluate.Location = New System.Drawing.Point(248, 76)
        Me.txtEvaluate.Size = New System.Drawing.Size(95, 21)
        '
        'cmbMeasure
        '
        Me.cmbMeasure.DropDownWidth = 120
        Me.cmbMeasure.ItemHeight = 12
        Me.cmbMeasure.Location = New System.Drawing.Point(280, 22)
        Me.cmbMeasure.Size = New System.Drawing.Size(120, 20)
        '
        'dateEvaluate
        '
        Me.dateEvaluate.Location = New System.Drawing.Point(488, 46)
        Me.dateEvaluate.Size = New System.Drawing.Size(112, 21)
        Me.dateEvaluate.Value = New Date(2003, 4, 2, 16, 56, 35, 859)
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(72, 46)
        Me.txtRemark.Size = New System.Drawing.Size(328, 21)
        '
        'txtGuarantee
        '
        Me.txtGuarantee.Location = New System.Drawing.Point(583, 78)
        Me.txtGuarantee.Size = New System.Drawing.Size(99, 21)
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.AccessibleName = "DataGrid"
        Me.dgOppGuarantee.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgOppGuarantee.ReadOnly = True
        Me.dgOppGuarantee.Size = New System.Drawing.Size(322, 284)
        Me.dgOppGuarantee.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'dgDetail
        '
        Me.dgDetail.AccessibleName = "DataGrid"
        Me.dgDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgDetail.ReadOnly = True
        Me.dgDetail.Size = New System.Drawing.Size(346, 284)
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(8, 341)
        Me.GroupBox4.Size = New System.Drawing.Size(688, 109)
        '
        'Label3
        '
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.Text = " 类 型"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.Text = " 原 值"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(166, 80)
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(208, 24)
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(514, 84)
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(424, 48)
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 48)
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.Text = " 备 注"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(424, 24)
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        '
        'txtContract
        '
        Me.txtContract.Location = New System.Drawing.Point(488, 22)
        Me.txtContract.Size = New System.Drawing.Size(112, 21)
        '
        'txtName
        '
        Me.txtName.Size = New System.Drawing.Size(376, 21)
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(616, 456)
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.Images.SetKeyName(0, "")
        Me.ImageListBasic.Images.SetKeyName(1, "")
        Me.ImageListBasic.Images.SetKeyName(2, "")
        Me.ImageListBasic.Images.SetKeyName(3, "")
        Me.ImageListBasic.Images.SetKeyName(4, "")
        Me.ImageListBasic.Images.SetKeyName(5, "")
        Me.ImageListBasic.Images.SetKeyName(6, "")
        Me.ImageListBasic.Images.SetKeyName(7, "")
        Me.ImageListBasic.Images.SetKeyName(8, "")
        Me.ImageListBasic.Images.SetKeyName(9, "")
        Me.ImageListBasic.Images.SetKeyName(10, "")
        Me.ImageListBasic.Images.SetKeyName(11, "")
        Me.ImageListBasic.Images.SetKeyName(12, "")
        Me.ImageListBasic.Images.SetKeyName(13, "")
        Me.ImageListBasic.Images.SetKeyName(14, "")
        Me.ImageListBasic.Images.SetKeyName(15, "")
        Me.ImageListBasic.Images.SetKeyName(16, "")
        Me.ImageListBasic.Images.SetKeyName(17, "")
        Me.ImageListBasic.Images.SetKeyName(18, "")
        Me.ImageListBasic.Images.SetKeyName(19, "")
        Me.ImageListBasic.Images.SetKeyName(20, "")
        Me.ImageListBasic.Images.SetKeyName(21, "")
        Me.ImageListBasic.Images.SetKeyName(22, "")
        Me.ImageListBasic.Images.SetKeyName(23, "")
        Me.ImageListBasic.Images.SetKeyName(24, "")
        Me.ImageListBasic.Images.SetKeyName(25, "")
        Me.ImageListBasic.Images.SetKeyName(26, "")
        Me.ImageListBasic.Images.SetKeyName(27, "")
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 27
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(512, 456)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(96, 24)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "浏览图片(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgOppGuarantee
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn6})
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
        Me.DataGridTextBoxColumn4.HeaderText = "原值"
        Me.DataGridTextBoxColumn4.MappingName = "original_value"
        Me.DataGridTextBoxColumn4.NullText = "0.00"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "评估总值"
        Me.DataGridTextBoxColumn5.MappingName = "evaluate_value"
        Me.DataGridTextBoxColumn5.NullText = "0.00"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "担保额"
        Me.DataGridTextBoxColumn6.MappingName = "guarantee_value"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "评估净值"
        Me.DataGridTextBoxColumn9.MappingName = "evaluate_net_value"
        Me.DataGridTextBoxColumn9.NullText = "0.00"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'frmOppGuaranteeQueryCheck
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(706, 487)
        Me.Controls.Add(Me.btnView)
        Me.Name = "frmOppGuaranteeQueryCheck"
        Me.Text = "反担保物查询"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.btnView, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmOppGuaranteeQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.strProjectCode = Me.getProjectCode()
        'Me.strCorporationName = Me.getCorporationName()
        'Me.strWorkFlowID = Me.getWorkFlowID()
        'Me.strTaskID = Me.getTaskID()
        'Me.strPerson = Me.getUser
        'Me.dateEvaluate.Value = Now.Today

        Me.txtCode.Text = Me.strProjectCode
        'Me.txtName.Text = Me.strCorporationName

		dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode)
        If Not dsOppGuaranteeView Is Nothing Then
            dsOppGuaranteeView.AcceptChanges()
            Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
        End If
        setTextBox(False)
        'qxd add 2004-8-17
        If IsAllowViewPicture() Then
            Me.btnView.Enabled = True
        Else
            Me.btnView.Enabled = False
        End If
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
            'MsgBox(ex.ToString)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
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
    '
    '点击dgOppGuarantee
    '
    Private Sub dgOppGuarantee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOppGuarantee.Click
        getDetail()
        getOppGuaranteeInfo()
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
                End If
                If Not .Item("evaluate_value") Is System.DBNull.Value Then
                    Me.txtEvaluate.Text = .Item("evaluate_value")
                End If
                If Not .Item("evaluate_net_value") Is System.DBNull.Value Then
                    Me.txtEvaluateNet.Text = .Item("evaluate_net_value")
                End If
                If Not .Item("guarantee_value") Is System.DBNull.Value Then
                    Me.txtGuarantee.Text = .Item("guarantee_value")
                End If
                If Not .Item("evaluate_date") Is System.DBNull.Value Then
                    Me.dateEvaluate.Value = .Item("evaluate_date")
                End If
                If Not .Item("contract_no") Is System.DBNull.Value Then
                    Me.txtContract.Text = .Item("contract_no")
                End If
                If Not .Item("remark") Is System.DBNull.Value Then
                    Me.txtRemark.Text = .Item("remark")
                End If
                If Not .Item("guaranty_type") Is System.DBNull.Value Then
                    Me.cmbType.Text = getGuaranteeType(.Item("guaranty_type"))
                End If
                If Not .Item("opposite_guarantee_form") Is System.DBNull.Value Then
                    Me.cmbMeasure.Text = getGuaranteeForm(.Item("opposite_guarantee_form"))
                End If
            End With
        Catch ex As Exception
            ' MsgBox(ex.ToString)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        End Try
    End Sub

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
        'If Not ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num") Is System.DBNull.Value Then
        '    strRelationNum = ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num")
        '    Me.Cursor = Cursors.WaitCursor
        '    Dim docClass As New frmDocumentClass()
        '    'docClass.openFileList(strProjectCode, strItemType, "", strDir)
        '    docClass.openFileList(strProjectCode, "2%", "", strDir)
        '    Me.Cursor = Cursors.Default
        'Else
        '    'MsgBox("没有相关的图片!", MsgBoxStyle.Exclamation, "提示")
        '    SWDialogBox.MessageBox.Show("$1007", "相关的图片")
        'End If
        Me.Cursor = Cursors.WaitCursor
        Dim docClass As New frmDocumentClass()
        'docClass.openFileList(strProjectCode, strItemType, "", strDir)
        docClass.openFileList(strProjectCode, "2%", "", strDir)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub setTextBox(ByVal isEnabled As Boolean)
        Me.txtOriginal.Enabled = isEnabled
        Me.txtGuarantee.Enabled = isEnabled
        Me.txtEvaluate.Enabled = isEnabled
        Me.txtEvaluateNet.Enabled = isEnabled
        Me.txtContract.Enabled = isEnabled
        Me.cmbType.Enabled = isEnabled
        Me.dateEvaluate.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
        Me.cmbMeasure.Enabled = isEnabled
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        'Dim strMesg As Integer
        'strMesg = MsgBox("数据已修改，是否保存？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "提示")
        'If 6 = strMesg Then
        '    Me.Close()
        'ElseIf strMesg = 7 Then
        '    Me.Close()
        'End If
        Me.Close()
    End Sub

    Private Sub frmOppGuaranteeQuery_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
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
