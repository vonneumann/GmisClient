
'监管,抵押,质押手续确认完全相同,处于平行地位,但为了方便管理,所有有一个继承关系
Public Class frmWardAffirm
    Inherits MainInterface.frmBasic

    Private strProjectCode As String
    Private strCorporationName As String
    Private strTaskID As String
    Private strWorkFlowID As String
    Private strPerson As String
    Private strOppForm As String '反担保措施
    Private strItemType As String = "44"
    Private strItemCode As String
    Private strPhase As String = " "
    Private strDir As String = "\Document\Image\" '图片保存的目录
    Private strStatus As String = "评审通过"
    Private dsTemp As DataSet
    Private isOnlyView As Boolean = False '所有的DataGrid只能查看
    Private isChanged As Boolean = False
    Private iIndex As Integer = -1

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    Public Sub New(ByVal projectCode As String, ByVal isOnlyView As Boolean)
        Me.new()

        Me.strProjectCode = projectCode
        Me.isOnlyView = isOnlyView
        Me.btnCommit.Enabled = False
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDetail As System.Windows.Forms.DataGrid
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents dgOppGuarantee As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgMain As System.Windows.Forms.DataGrid
    Friend WithEvents dgAdditional As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWardAffirm))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgOppGuarantee = New System.Windows.Forms.DataGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgDetail = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgMain = New System.Windows.Forms.DataGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgAdditional = New System.Windows.Forms.DataGrid()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgAdditional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(411, 428)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgOppGuarantee})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "反担保物记录"
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.CaptionVisible = False
        Me.dgOppGuarantee.DataMember = ""
        Me.dgOppGuarantee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOppGuarantee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgOppGuarantee.Location = New System.Drawing.Point(3, 17)
        Me.dgOppGuarantee.Name = "dgOppGuarantee"
        Me.dgOppGuarantee.Size = New System.Drawing.Size(434, 156)
        Me.dgOppGuarantee.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDetail})
        Me.GroupBox3.Location = New System.Drawing.Point(456, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 176)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "反担保物详细信息"
        '
        'dgDetail
        '
        Me.dgDetail.CaptionVisible = False
        Me.dgDetail.DataMember = ""
        Me.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetail.Location = New System.Drawing.Point(3, 17)
        Me.dgDetail.Name = "dgDetail"
        Me.dgDetail.ReadOnly = True
        Me.dgDetail.Size = New System.Drawing.Size(242, 156)
        Me.dgDetail.TabIndex = 0
        Me.dgDetail.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgDetail
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "opposite_guarantee_detail"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "类目"
        Me.DataGridTextBoxColumn1.MappingName = "item_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "描述"
        Me.DataGridTextBoxColumn2.MappingName = "item_value"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(327, 428)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 5
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Bitmap)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 17
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(227, 428)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = "浏览图片(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(320, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(384, 21)
        Me.txtName.TabIndex = 9
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(264, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(136, 21)
        Me.txtCode.TabIndex = 7
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgMain})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 200)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "反担保措施"
        '
        'dgMain
        '
        Me.dgMain.CaptionVisible = False
        Me.dgMain.DataMember = ""
        Me.dgMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMain.Location = New System.Drawing.Point(3, 17)
        Me.dgMain.Name = "dgMain"
        Me.dgMain.Size = New System.Drawing.Size(690, 180)
        Me.dgMain.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgAdditional})
        Me.GroupBox4.Location = New System.Drawing.Point(704, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(696, 8)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "附加反担保措施"
        Me.GroupBox4.Visible = False
        '
        'dgAdditional
        '
        Me.dgAdditional.CaptionVisible = False
        Me.dgAdditional.DataMember = ""
        Me.dgAdditional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAdditional.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgAdditional.Location = New System.Drawing.Point(3, 17)
        Me.dgAdditional.Name = "dgAdditional"
        Me.dgAdditional.Size = New System.Drawing.Size(690, 0)
        Me.dgAdditional.TabIndex = 0
        '
        'frmWardAffirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 455)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox4, Me.GroupBox1, Me.txtName, Me.Label2, Me.txtCode, Me.Label1, Me.btnView, Me.btnCommit, Me.GroupBox3, Me.GroupBox2, Me.btnExit})
        Me.Name = "frmWardAffirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "监管手续确认"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgAdditional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Load（）
    Private Sub frmWardAffirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not isOnlyView Then
            Me.strProjectCode = Me.getProjectCode()
            Me.strCorporationName = Me.getCorporationName()
            Me.strWorkFlowID = Me.getWorkFlowID()
            Me.strTaskID = Me.getTaskID()
            Me.strPerson = Me.getUser
            strPhase = Me.getPhase(Me.strProjectCode)
        End If

        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName

        Me.selectForm()

        getFormInfo() '取得反担保措施记录
        getOppInfo() '取得反担保物
        getDetail() '取得反担保详细记录
        setButton()
    End Sub
    '设置担保措施strOppForm
    Public Sub setOppForm(ByVal oppForm As String)
        Me.strOppForm = oppForm
    End Sub
    '获得反担保措施(主的和附加的)记录
    Private Sub getFormInfo()

        Dim dsItemType As DataSet

        Try
            dsTemp = gWs.GetProjectGuaranteeFormAdditional(Me.strProjectCode, Me.strItemType, Me.strItemCode)
            If Not dsTemp Is Nothing Then

                dsTemp.Tables("TProjectGuaranteeForm").Columns.Add("type_name", GetType(String))
                dsTemp.Tables("TProjectGuaranteeFormAdditional").Columns.Add("type_name", GetType(String))

                Dim i As Int16
                Dim dr As DataRow

                i = dsTemp.Tables("TProjectGuaranteeForm").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = dsTemp.Tables("TProjectGuaranteeForm").Rows(i)

                        If dr.Item("is_checked") Is System.DBNull.Value Then
                            dr.Item("is_checked") = False
                        End If

                        If Not dr.Item("guaranty") Is System.DBNull.Value Then
                            dsItemType = getItemTypeDataSet(dr.Item("guaranty"))
                            'oppGuarantee显示的类型名映射为ItemType中的typeName
                            dr.Item("type_name") = dsItemType.Tables("TItemType").Select("item_type='" & dr.Item("guaranty") & "'")(0).Item("type_name")
                        End If

                    Next
                End If

                i = dsTemp.Tables("TProjectGuaranteeFormAdditional").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = dsTemp.Tables("TProjectGuaranteeFormAdditional").Rows(i)

                        If dr.Item("is_checked") Is System.DBNull.Value Then
                            dr.Item("is_checked") = False
                        End If

                        If Not dr.Item("guaranty") Is System.DBNull.Value Then
                            dsItemType = getItemTypeDataSet(dr.Item("guaranty"))
                            'oppGuarantee显示的类型名映射为ItemType中的typeName
                            dr.Item("type_name") = dsItemType.Tables("TItemType").Select("item_type='" & dr.Item("guaranty") & "'")(0).Item("type_name")
                        End If

                    Next
                End If

                addStyle1(dsTemp)
                addStyle2(dsTemp)

                Me.dgMain.DataSource = dsTemp.Tables("TProjectGuaranteeForm")
                Me.dgAdditional.DataSource = dsTemp.Tables("TProjectGuaranteeFormAdditional")

                setDgAttribute(Me.dgMain, Me)
                setDgAttribute(Me.dgAdditional, Me)
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
        End Try
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            'If MsgBoxResult.Yes = MsgBox("是否确认提交?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "提示") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1000", "提交") Then
                commit()
            End If
        Else
            commit()
        End If
    End Sub
    '提交处理
    Private Sub commit()

        '用于限定必须所有的相都确认才能提交
        'If isAccreditCommit() Then
        '    'MsgBox("有未确认的反担保物记录,不能提交!", MsgBoxStyle.Exclamation, "提示")
        '    SWDialogBox.MessageBox.Show("$1004", "未确认的反担保物")
        '    Exit Sub
        'End If

        '有一个相被确认了,就须向project_document中添加记录
        '都没确认,则须删除project_document中的记录
        addProjectDocumentRecord(Me.isOneAffirm)

        '保存确认相
        If Me.Affirm() = False Then
            Exit Sub
        End If
        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If "1" = strCommit Then
            'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            raiseCommitSucceed()
            Me.Close()
        Else
            'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
        End If
    End Sub
    '获得反担保物记录
    Private Sub getOppInfo()
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strItemType As String
        Dim dsItemType As DataSet
        strSql = "{project_code='" & strProjectCode & "' and opposite_guarantee_form like '%" & strOppForm & "%' and status<>'申请'}"
        'strSql = "{project_code='" & strProjectCode & "' and status<>'申请'}"

        Try
            ds = gWs.GetGuarantyInfo(strSql, "null")
            ds.Tables("opposite_guarantee").Columns.Add("is_check", GetType(Boolean))
            ds.Tables("opposite_guarantee").Columns.Add("type_name", GetType(String))
            i = ds.Tables("opposite_guarantee").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dr = ds.Tables("opposite_guarantee").Rows(i)
                    With dr

                        .Item("is_check") = False

                        Try
                            If Not .Item("guaranty_type") Is System.DBNull.Value Then
                                strItemType = .Item("guaranty_type")
                                dsItemType = getItemTypeDataSet(strItemType)
                                'oppGuarantee显示的类型名映射为ItemType中的typeName
                                .Item("type_name") = dsItemType.Tables("TItemType").Select("item_type='" & strItemType & "'")(0).Item("type_name")
                            End If
                        Catch ex As Exception
                            'MsgBox("获取反担保物类型出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
                            ExceptionHandler.ShowMessageBox(ex)
                        End Try
                    End With
                Next
            End If
            addStyle(ds)
            Me.dgOppGuarantee.DataSource = ds.Tables("opposite_guarantee")
            setDgAttribute(Me.dgOppGuarantee, Me)
        Catch
        Finally
        End Try
    End Sub
    '
    '获得ItemType表的DataSet
    '
    Private Function getItemTypeDataSet(ByVal strItemType As String) As DataSet
        Dim ds As DataSet
        Try
            ds = gWs.GetItemType("{item_type='" & strItemType & "'}")
            Return ds
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '获得Item表的DataSet
    '
    Public Function getItemDataSet(ByVal strItemType As String) As DataSet
        Dim ds As DataSet
        Try
            ds = gWs.GetItem("{item_type='" & strItemType & "'}", Nothing)
            Return ds
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '
    '获得反担保物的详细信息
    '
    Private Sub getDetail()
        Dim index As Integer
        Dim strCode, strSerial, strType, strState As String
        Dim dt As DataTable
        index = Me.dgOppGuarantee.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
            strCode = dt.Rows(index).Item("project_code")
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not dt.Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerial = dt.Rows(index).Item("serial_num")
            If Not dt.Rows(index).Item("guaranty_type") Is System.DBNull.Value Then
                strType = dt.Rows(index).Item("guaranty_type")
            End If
            If Not dt.Rows(index).Item("status") Is System.DBNull.Value Then
                strState = dt.Rows(index).Item("status")
            End If
            getOppGuaranteeDetail(strCode, strSerial, strType)
            Me.dgDetail.DataSource = getOppGuaranteeDetail(strCode, strSerial, strType).Tables("opposite_guarantee_detail")
        Else
            Me.dgOppGuarantee.DataSource = Nothing
        End If
    End Sub
    '
    '根据project_code 和 serial_num、guaranty_type从opposite_guarantee_detail，获得详细信息
    '
    Private Function getOppGuaranteeDetail(ByVal strProjectCode As String, ByVal strSerialNum As String, ByVal strItemType As String) As DataSet

        Dim ds As DataSet
        Dim dsItem, dsItemType As DataSet
        Dim strType, strItemCode As String
        Try
            ds = gWs.GetGuarantyInfo("null", "{project_code ='" & strProjectCode & "' and serial_num='" & strSerialNum & "' and item_type='" & strItemType & "'}")
            ds.Tables("opposite_guarantee_detail").Columns.Add("type_name", GetType(String))
            ds.Tables("opposite_guarantee_detail").Columns.Add("item_name", GetType(String))

            dsItem = getItemDataSet(strItemType)
            dsItemType = getItemTypeDataSet(strItemType)
            Dim j As Integer
            j = ds.Tables("opposite_guarantee_detail").Rows.Count
            Try
                For j = 0 To j - 1
                    Dim str_item_code, str_item_type As String
                    str_item_code = ds.Tables("opposite_guarantee_detail").Rows(j).Item("item_code")
                    str_item_type = ds.Tables("opposite_guarantee_detail").Rows(j).Item("item_type")

                    Dim dr As DataRow()
                    dr = dsItem.Tables("TItem").Select("item_code='" & str_item_code & "' and item_type='" & str_item_type & "'")
                    If dr.Length > 0 Then
                        ds.Tables("opposite_guarantee_detail").Rows(j).Item("item_name") = dr(0).Item("item_name")
                    Else
                        ds.Tables("opposite_guarantee_detail").Rows(j).Item("item_name") = "未知"
                    End If
                    dr = dsItemType.Tables("TItemType").Select("item_type='" & str_item_type & "'")
                    If dr.Length > 0 Then
                        ds.Tables("opposite_guarantee_detail").Rows(j).Item("type_name") = dr(0).Item("type_name")
                    Else
                        ds.Tables("opposite_guarantee_detail").Rows(j).Item("type_name") = "未知"
                    End If
                Next
            Catch ex As Exception
                'MsgBox("获取反担保物类型出错!", MsgBoxStyle.Critical, "提示")
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            Return ds
        Catch ex As Exception
        End Try
    End Function

    '选择具体是那种反担保措施
    Private Sub selectForm()
        Select Case Me.Text.Substring(0, 2)
            Case "监管"
                Me.strItemCode = "013"
                Me.strOppForm = "监管"
            Case "抵押"
                Me.strItemCode = "006"
                Me.strOppForm = "抵押"
            Case "质押"
                Me.strItemCode = "007"
                Me.strOppForm = "质押"
            Case Else
                Me.strItemCode = ""
        End Select

    End Sub

    '保存主反担保措施,附加反担保措施,反担保物记录的确认相(is_checked)
    Private Function Affirm() As Boolean
        Dim ds As DataSet
        Dim strResult As String

        Try

            strResult = gWs.UpdateProjectGuaranteeForm(dsTemp)

            If strResult = "1" Then

                dsTemp.Tables("TProjectGuaranteeForm").AcceptChanges()
                strResult = gWs.UpdateProjectGuaranteeFormAdd(dsTemp)
            Else
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                Return False
            End If

            If strResult = "1" Then
                dsTemp.Tables("TProjectGuaranteeFormAdditional").AcceptChanges()
                ds = CType(Me.dgOppGuarantee.DataSource, DataTable).DataSet
                Dim i As Int16 = ds.Tables(0).Rows.Count
                Dim dr As DataRow
                For i = 0 To i - 1
                    dr = ds.Tables(0).Rows(i)
                    If dr.Item("status") = Me.strStatus And dr.Item("is_check") Then
                        dr.Item("status") = "抵押质押"
                    End If
                Next

                strResult = gWs.UpdateGuaranty(ds)
            Else
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                Return False
            End If

            If strResult = "1" Then
                ds.AcceptChanges()
                Return True
            Else
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                Return False
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            Exit Function
        End Try
        dsTemp.AcceptChanges()
    End Function
    '添加确认的纪录到project_document表中
    Private Function addProjectDocumentRecord(ByVal isAdd As Boolean) As Boolean
        If gWs Is Nothing Then
            Exit Function
        End If
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strResult As String
        ds = gWs.GetProjectDocumentByCondition("{project_code='" & Me.strProjectCode & "' and item_type='" & Me.strItemType & "' and item_code='" & Me.strItemCode & "'}")
        i = ds.Tables("TProjectDocument").Rows.Count
        If isAdd = True Then '修改或者增机记录
            If i = 1 Then
                dr = ds.Tables("TProjectDocument").Rows(0)
                With dr
                    .Item("phase") = strPhase
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
            ElseIf i = 0 Then
                dr = ds.Tables("TProjectDocument").NewRow
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("phase") = strPhase
                    .Item("item_type") = strItemType
                    .Item("item_code") = strItemCode
                    .Item("doc_name") = Me.Text
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
                ds.Tables("TProjectDocument").Rows.Add(dr)
            End If
        Else '删除记录
            If i = 1 Then
                ds.Tables("TProjectDocument").Rows(0).Delete()
            End If
        End If
        strResult = gWs.UpdateProjectDocument(ds)
        If strResult = "1" Then
        Else
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
        End If
    End Function

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
        ds = CType(Me.dgOppGuarantee.DataSource, DataTable).DataSet
        If Not ds.Tables("opposite_guarantee").Rows(index).Item("project_code") Is System.DBNull.Value Then
            strCode = ds.Tables("opposite_guarantee").Rows(index).Item("project_code")
        End If
        If Not ds.Tables("opposite_guarantee").Rows(index).Item("guaranty_type") Is System.DBNull.Value Then
            strItemType = ds.Tables("opposite_guarantee").Rows(index).Item("guaranty_type")
        End If
        If Not ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num") Is System.DBNull.Value Then
            strRelationNum = ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num")
            Me.Cursor = Cursors.WaitCursor
            Dim docClass As New frmDocumentClass("")
            'docClass.openFileList(strProjectCode, strItemType, "", strDir)
            docClass.openFileList(strProjectCode, "2%", "", strDir)
            Me.Cursor = Cursors.Default
        Else
            'MsgBox("没有相关的图片!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1005", "图片")
        End If
    End Sub
    '根据是否有文件设置"浏览图片"按钮的Enable属性
    Private Sub setButton()
        Dim dt As DataTable
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
            If dt.Rows.Count > 0 Then
                If dt.Rows(Me.dgOppGuarantee.CurrentRowIndex).Item("file_relation_num") Is System.DBNull.Value Then
                    Me.btnView.Enabled = False
                Else
                    Me.btnView.Enabled = True
                End If
            Else
                Me.btnView.Enabled = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '判断是否有相确认
    '有一个确认,返回true
    Private Function isOneAffirm() As Boolean

        Dim dt As DataTable = CType(Me.dgOppGuarantee.DataSource, DataTable)
        Dim i As Int16 = dt.Rows.Count
        For i = 0 To i - 1
            If dt.Rows(i).Item("is_check") Then
                Return True '有一个确认,则退出并返回true
            End If
        Next

        dt = Me.dsTemp.Tables("TProjectGuaranteeForm")
        i = dt.Rows.Count
        For i = 0 To i - 1
            If dt.Rows(i).Item("is_checked") Then
                Return True '有一个确认,则退出并返回true
            End If
        Next

        dt = Me.dsTemp.Tables("TProjectGuaranteeFormAdditional")
        i = dt.Rows.Count
        For i = 0 To i - 1
            If dt.Rows(i).Item("is_checked") Then
                Return True '有一个确认,则退出并返回true
            End If
        Next

        Return False '如果都没确认,或者dt.rows.count=0,返回false

    End Function

    '添加dgOppguarantee的style
    Private Sub addStyle(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "opposite_guarantee"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("opposite_guarantee").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)

        Dim bColumnTextColumn As DataGridColoredBoolColumn
        bColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        If Me.isOnlyView Then
            bColumnTextColumn.Width = 0
        End If
        bColumnTextColumn.HeaderText = "确认"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.MappingName = "is_check"
        bColumnTextColumn.ReadOnly = Me.isOnlyView
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Dim column_7 As New DataGridTextBoxColumn()
        column_7.ReadOnly = True
        column_7.Width = 75
        column_7.NullText = ""
        column_7.HeaderText = "状态"
        column_7.MappingName = "status"
        tableStyle.GridColumnStyles.Add(column_7)

        Dim column_11 As New DataGridTextBoxColumn() '不可见
        column_11.Width = 0
        column_11.ReadOnly = True
        column_11.NullText = ""
        column_11.HeaderText = "项目编码"
        column_11.MappingName = "project_code"
        tableStyle.GridColumnStyles.Add(column_11)

        Dim column_1 As New DataGridTextBoxColumn()
        column_1.Width = 70
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "类型"
        column_1.MappingName = "type_name"
        tableStyle.GridColumnStyles.Add(column_1)

        Dim column_8 As New DataGridTextBoxColumn()
        column_8.ReadOnly = True
        column_8.Width = 75
        column_8.NullText = ""
        column_8.HeaderText = "反担保措施"
        column_8.MappingName = "opposite_guarantee_form"
        tableStyle.GridColumnStyles.Add(column_8)

        Dim column_2 As New DataGridTextBoxColumn()
        column_2.ReadOnly = True
        column_2.Width = 75
        column_2.NullText = "0"
        column_2.HeaderText = "原值(元)"
        column_2.MappingName = "original_value"
        tableStyle.GridColumnStyles.Add(column_2)
        'add  yansm 评估净值
        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.Width = 75
        column_3.NullText = "0"
        column_3.HeaderText = "评估总值(元)"
        column_3.MappingName = "evaluate_value"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_14 As New DataGridTextBoxColumn()
        column_14.ReadOnly = True
        column_14.Width = 75
        column_14.NullText = "0"
        column_14.HeaderText = "评估净值(元)"
        column_14.MappingName = "evaluate_net_value"
        tableStyle.GridColumnStyles.Add(column_14)


        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = "0"
        column_4.HeaderText = "担保额(元)"
        column_4.MappingName = "guarantee_value"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_5 As New DataGridTextBoxColumn()
        column_5.ReadOnly = True
        column_5.NullText = ""
        column_5.HeaderText = "备注"
        column_5.MappingName = "remark"
        tableStyle.GridColumnStyles.Add(column_5)

        Me.dgOppGuarantee.TableStyles.Clear()
        Me.dgOppGuarantee.TableStyles.Add(tableStyle)
    End Sub

    '添加dgMain的style
    Private Sub addStyle1(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "TProjectGuaranteeForm"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("TProjectGuaranteeForm").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)


        Dim bColumnTextColumn As DataGridColoredBoolColumn
        bColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        bColumnTextColumn.HeaderText = "确认"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.MappingName = "is_checked"
        bColumnTextColumn.ReadOnly = Me.isOnlyView
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        '
        Dim column_1 As New DataGridTextBoxColumn() '不可见
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "项目编码"
        column_1.MappingName = "project_code"
        column_1.Width = 0
        tableStyle.GridColumnStyles.Add(column_1)

        Dim column_2 As New DataGridTextBoxColumn()
        column_2.Width = 70
        column_2.ReadOnly = True
        column_2.NullText = ""
        column_2.HeaderText = "类型"
        column_2.MappingName = "type_name"
        tableStyle.GridColumnStyles.Add(column_2)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = ""
        column_4.HeaderText = "反担保形式"
        column_4.MappingName = "guarantee_form"
        tableStyle.GridColumnStyles.Add(column_4)

        'Dim column_3 As New DataGridTextBoxColumn() '不可见
        'column_3.ReadOnly = True
        'column_3.NullText = ""
        'column_3.HeaderText = "反担保物"
        'column_3.MappingName = "guarantee"
        'column_3.Width = 0
        'tableStyle.GridColumnStyles.Add(column_3)



        Dim column_5 As New DataGridTextBoxColumn()
        column_5.ReadOnly = True
        column_5.NullText = "0"
        column_5.HeaderText = "反担保金额"
        column_5.MappingName = "guarantee_sum"
        tableStyle.GridColumnStyles.Add(column_5)


        Dim column_6 As New DataGridTextBoxColumn()
        column_6.ReadOnly = True
        column_6.NullText = ""
        column_6.HeaderText = "备注"
        column_6.Width = 250
        column_6.MappingName = "description"
        tableStyle.GridColumnStyles.Add(column_6)

        Me.dgMain.TableStyles.Clear()
        Me.dgMain.TableStyles.Add(tableStyle)
    End Sub
    '添加dgAdditional的style
    Private Sub addStyle2(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "TProjectGuaranteeFormAdditional"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("TProjectGuaranteeFormAdditional").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)

        Dim bColumnTextColumn As DataGridColoredBoolColumn
        bColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        bColumnTextColumn.HeaderText = "确认"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.MappingName = "is_checked"
        bColumnTextColumn.ReadOnly = Me.isOnlyView
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Dim column_2 As New DataGridTextBoxColumn()
        column_2.Width = 70
        column_2.ReadOnly = True
        column_2.NullText = ""
        column_2.HeaderText = "类型"
        column_2.MappingName = "type_name"
        tableStyle.GridColumnStyles.Add(column_2)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = ""
        column_4.HeaderText = "反担保形式"
        column_4.MappingName = "guarantee_form"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_7 As New DataGridTextBoxColumn()
        column_7.ReadOnly = True
        column_7.NullText = ""
        column_7.HeaderText = "附加反担保形式"
        column_7.Width = 100
        column_7.MappingName = "additional_guarantee_form"
        tableStyle.GridColumnStyles.Add(column_7)


        Me.dgAdditional.TableStyles.Clear()
        Me.dgAdditional.TableStyles.Add(tableStyle)
    End Sub

    Private Sub dgMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgMain.MouseUp
        If Me.dgMain.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgMain.DataSource, DataTable).Rows.Count > 0 Then
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgMain.CurrentCell.RowNumber
            colNum = Me.dgMain.CurrentCell.ColumnNumber
            If colNum = 0 And Not Me.isOnlyView Then
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgMain.Item(rowNum, colNum) = Not Me.dgMain.Item(rowNum, colNum)

                Dim dt As DataTable = CType(Me.dgOppGuarantee.DataSource, DataTable)
                Dim i As Int16 = dt.Rows.Count()
                For i = 0 To i - 1 '存在多条对应的可能
                    If dt.Rows(i).Item("project_code") = Me.dgMain.Item(rowNum, 1) And _
                    dt.Rows(i).Item("type_name") = Me.dgMain.Item(rowNum, 2) And _
                    dt.Rows(i).Item("opposite_guarantee_form") = Me.dgMain.Item(rowNum, 3) And _
                    dt.Rows(i).Item("status") = Me.strStatus Then '满足四个条件

                        dt.Rows(i).Item("is_check") = dgMain.Item(rowNum, colNum) '所有的随着变化

                    End If
                Next
            End If
            Me.dgMain.Select(Me.dgMain.CurrentCell.RowNumber)
        End If
    End Sub

    Private Sub dgAdditional_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgAdditional.MouseUp

        If Me.dgAdditional.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgAdditional.DataSource, DataTable).Rows.Count > 0 Then
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgAdditional.CurrentCell.RowNumber
            colNum = Me.dgAdditional.CurrentCell.ColumnNumber
            If colNum = 0 And Not Me.isOnlyView Then
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgAdditional.Item(rowNum, colNum) = Not Me.dgAdditional.Item(rowNum, colNum)
                Me.isChanged = True
            End If
            Me.dgAdditional.Select(Me.dgAdditional.CurrentCell.RowNumber)
        End If

    End Sub


    Private Sub dgOppGuarantee_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOppGuarantee.MouseUp
        If Me.dgOppGuarantee.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgOppGuarantee.DataSource, DataTable).Rows.Count > 0 Then
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgOppGuarantee.CurrentCell.RowNumber
            colNum = Me.dgOppGuarantee.CurrentCell.ColumnNumber
            If Me.dgOppGuarantee.Item(rowNum, 1) = Me.strStatus Then '是评审必能选中
                If colNum = 0 And Not Me.isOnlyView Then  '满足三个条件才能
                    Dim he As DataGrid = CType(sender, DataGrid)
                    If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                    Me.dgOppGuarantee.Item(rowNum, colNum) = Not Me.dgOppGuarantee.Item(rowNum, colNum)
                    Me.isChanged = True

                    '和反担保措施之间的对应关系
                    Dim dt As DataTable = CType(Me.dgMain.DataSource, DataTable)
                    Dim strSql As String = "project_code='" & Me.dgOppGuarantee.Item(rowNum, 2) _
                                                        & "' and type_name='" & Me.dgOppGuarantee.Item(rowNum, 3) _
                                                        & "' and guarantee_form='" & Me.dgOppGuarantee.Item(rowNum, 4) & "'"
                    If Me.dgOppGuarantee.Item(rowNum, colNum) = True Then '如果有一个反担保物确认,则反担保措施就确认

                        If dt.Select(strSql).Length > 0 Then
                            dt.Select(strSql)(0).Item("is_checked") = True
                        End If

                    Else '所有的反担保物都没确认,反担保措施就不确认
                        Dim dtOpp As DataTable = CType(Me.dgOppGuarantee.DataSource, DataTable)
                        Dim i As Int16 = dtOpp.Rows.Count
                        Dim boo As Boolean = False
                        For i = 0 To i - 1
                            If dtOpp.Rows(i).Item("project_code") = Me.dgOppGuarantee.Item(rowNum, 2) And _
                                       dtOpp.Rows(i).Item("type_name") = Me.dgOppGuarantee.Item(rowNum, 3) And _
                                       dtOpp.Rows(i).Item("opposite_guarantee_form") = Me.dgOppGuarantee.Item(rowNum, 4) Then   '满足三个条件

                                If dt.Select(strSql).Length > 0 Then
                                    boo = boo Or dtOpp.Rows(i).Item("is_check")
                                End If
                            End If
                        Next
                        dt.Select(strSql)(0).Item("is_checked") = boo
                    End If
                Else
                    Me.dgOppGuarantee.Item(rowNum, colNum) = Me.dgOppGuarantee.Item(rowNum, colNum)
                End If
                Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
            Else '不是评审通过的
                Me.dgOppGuarantee.Item(rowNum, colNum) = Me.dgOppGuarantee.Item(rowNum, colNum)
            End If

        End If
        getDetail()

        setButton()

    End Sub

    Private Sub dgOppGuarantee_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgOppGuarantee.CurrentCellChanged
        If iIndex <> dgOppGuarantee.CurrentRowIndex Then
            setButton()
            getDetail()
        End If
        iIndex = dgOppGuarantee.CurrentRowIndex
    End Sub
End Class

