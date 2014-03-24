'作者：罗庆锋；日期2003-04-05
Public Class frmProjectAppraisement
    Inherits frmBasic

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

    End Sub
    Public Sub New(ByVal _ProjectCode As String, ByVal _CorporationName As String)
        MyBase.New()
        InitializeComponent()
        ProjectCode = _ProjectCode
        CorporationName = _CorporationName
    End Sub


    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsAlarm Is Nothing Then
            dsAlarm.Dispose()
        End If
        If Not dsRecord Is Nothing Then
            dsRecord.Dispose()
        End If
        If Not dsProAppraiseMent Is Nothing Then
            dsProAppraiseMent.Dispose()
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
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgShow As System.Windows.Forms.DataGrid
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tpTrackInfo As System.Windows.Forms.TabPage
    Friend WithEvents tpOpinion As System.Windows.Forms.TabPage
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnLookDocument As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpAuditDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDetail As System.Windows.Forms.DataGrid
    Friend WithEvents dgRecord As System.Windows.Forms.DataGrid
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProjectAppraisement))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tpTrackInfo = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgDetail = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgRecord = New System.Windows.Forms.DataGrid()
        Me.tpOpinion = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpAuditDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgShow = New System.Windows.Forms.DataGrid()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnLookDocument = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.tpTrackInfo.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpOpinion.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(448, 360)
        Me.btnExit.Visible = True
        '
        'TabControl
        '
        Me.TabControl.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.TabControl.Controls.AddRange(New System.Windows.Forms.Control() {Me.tpTrackInfo, Me.tpOpinion})
        Me.TabControl.Location = New System.Drawing.Point(8, 40)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(536, 312)
        Me.TabControl.TabIndex = 5
        '
        'tpTrackInfo
        '
        Me.tpTrackInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox4, Me.GroupBox1})
        Me.tpTrackInfo.Location = New System.Drawing.Point(4, 21)
        Me.tpTrackInfo.Name = "tpTrackInfo"
        Me.tpTrackInfo.Size = New System.Drawing.Size(528, 287)
        Me.tpTrackInfo.TabIndex = 0
        Me.tpTrackInfo.Text = "保后跟踪信息"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDetail})
        Me.GroupBox4.Location = New System.Drawing.Point(0, 167)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(528, 120)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
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
        Me.dgDetail.Size = New System.Drawing.Size(522, 100)
        Me.dgDetail.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgRecord})
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 168)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'dgRecord
        '
        Me.dgRecord.CaptionVisible = False
        Me.dgRecord.DataMember = ""
        Me.dgRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRecord.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgRecord.Location = New System.Drawing.Point(3, 17)
        Me.dgRecord.Name = "dgRecord"
        Me.dgRecord.ReadOnly = True
        Me.dgRecord.Size = New System.Drawing.Size(522, 148)
        Me.dgRecord.TabIndex = 0
        '
        'tpOpinion
        '
        Me.tpOpinion.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.btnNew, Me.btnSave, Me.btnDelete})
        Me.tpOpinion.Location = New System.Drawing.Point(4, 21)
        Me.tpOpinion.Name = "tpOpinion"
        Me.tpOpinion.Size = New System.Drawing.Size(528, 287)
        Me.tpOpinion.TabIndex = 1
        Me.tpOpinion.Text = "项目评价"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label11, Me.dtpAuditDate, Me.Label10, Me.txtRemark})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(512, 88)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 14)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "意    见"
        '
        'dtpAuditDate
        '
        Me.dtpAuditDate.Enabled = False
        Me.dtpAuditDate.Location = New System.Drawing.Point(72, 14)
        Me.dtpAuditDate.Name = "dtpAuditDate"
        Me.dtpAuditDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpAuditDate.TabIndex = 19
        Me.dtpAuditDate.Value = New Date(2003, 4, 5, 13, 38, 5, 515)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 14)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "评价日期"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtRemark.Location = New System.Drawing.Point(72, 40)
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(432, 40)
        Me.txtRemark.TabIndex = 26
        Me.txtRemark.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgShow})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(512, 160)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'dgShow
        '
        Me.dgShow.CaptionVisible = False
        Me.dgShow.DataMember = ""
        Me.dgShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgShow.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgShow.Location = New System.Drawing.Point(3, 17)
        Me.dgShow.Name = "dgShow"
        Me.dgShow.ReadOnly = True
        Me.dgShow.Size = New System.Drawing.Size(506, 140)
        Me.dgShow.TabIndex = 4
        '
        'btnNew
        '
        Me.btnNew.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(256, 256)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(432, 256)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnDelete.Enabled = False
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(344, 256)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(248, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 22
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 21
        Me.txtProjectCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(184, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "企业名称"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "项目编码"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Location = New System.Drawing.Point(88, 400)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.TabIndex = 24
        Me.btnCommit.Text = "提交(&C)"
        '
        'btnLookDocument
        '
        Me.btnLookDocument.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnLookDocument.Image = CType(resources.GetObject("btnLookDocument.Image"), System.Drawing.Bitmap)
        Me.btnLookDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLookDocument.ImageIndex = 18
        Me.btnLookDocument.ImageList = Me.ImageListBasic
        Me.btnLookDocument.Location = New System.Drawing.Point(312, 360)
        Me.btnLookDocument.Name = "btnLookDocument"
        Me.btnLookDocument.Size = New System.Drawing.Size(128, 23)
        Me.btnLookDocument.TabIndex = 25
        Me.btnLookDocument.Text = "保后检查记录表(&L)"
        Me.btnLookDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmProjectAppraisement
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(554, 391)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnLookDocument, Me.btnCommit, Me.txtCorName, Me.txtProjectCode, Me.Label1, Me.Label2, Me.TabControl})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectAppraisement"
        Me.Text = "项目评价"
        Me.TabControl.ResumeLayout(False)
        Me.tpTrackInfo.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpOpinion.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ProjectCode As String
    Private CorporationName As String
    Private WorkFlowID As String
    Private TaskID As String

    Private dsRecord, dsAlarm As DataSet  'real dataset
    Private strStatus As String = String.Empty  '反映当前状态
    Private dsProAppraiseMent As DataSet
    Private OpinionSerialNum As Integer = 0
    Private bmOpinion, bmRecord As BindingManagerBase
    Private SystemDate As DateTime
    Private needRefresh As Boolean = False

    Private Sub DisableShow(ByVal sender As Object, ByVal e As PaintEventArgs)
        Me.Visible = False
    End Sub
    '
    '返回显示的保后记录及其预警情况
    '
    Private Sub GetDataSourceOfShow()
        dsRecord = New DataSet()
        dsRecord = gWs.GetCheckRecordInfo("{project_code LIKE '" & ProjectCode & "'}", "{project_code LIKE '" & ProjectCode & "'}")
        bmRecord = BindingContext(dsRecord, "guarantee_check_record")
        If bmRecord.Count = 0 Then
            SWDialogBox.MessageBox.Show("$X034")
            'MessageBox.Show("该项目没有保后记录，无法评价", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AddHandler Me.Paint, AddressOf DisableShow
            'Dim obj As Control
            'For Each obj In Controls
            '    obj.Enabled = False
            'Next
            'btnExit.Enabled = True
            Return
        End If
        Dim dsLocal As DataSet = New DataSet() '虚拟数据集，包含预警记录和预警数据字典
        dsLocal.Tables.Add(dsRecord.Tables("guarantee_check_alarm").Copy)
        Dim dsAlarmName As DataSet = gWs.GetAlarmCode("%")
        dsLocal.Merge(dsAlarmName.Tables("TAlarmCode"))
        Dim parCols(1) As DataColumn
        Dim chdCols(1) As DataColumn
        parCols(0) = dsLocal.Tables("TAlarmCode").Columns("alarm_type")
        parCols(1) = dsLocal.Tables("TAlarmCode").Columns("alarm_code")
        chdCols(0) = dsLocal.Tables("guarantee_check_alarm").Columns("alarm_type")
        chdCols(1) = dsLocal.Tables("guarantee_check_alarm").Columns("alarm")
        dsLocal.Relations.Add("Alarm", parCols, chdCols)
        dsLocal.Tables("guarantee_check_alarm").Columns.Add("AlarmName", GetType(String), "Parent(Alarm).alarm_name")
        Dim dsAlarmType As DataSet = gWs.GetAlarmType("%")

        dsAlarm = New DataSet()  '预警记录的概括
        dsAlarm.Tables.Add(New DataTable("Table"))
        With dsAlarm.Tables(0)
            .Columns.Add("SerialNum", GetType(Integer))
            .Columns.Add("AlarmType", GetType(String))
            .Columns.Add("AlarmTypeName", GetType(String))
            .Columns.Add("Items", GetType(String))
        End With
        Dim dr As DataRow
        Dim drs() As DataRow
        For Each dr In dsLocal.Tables("guarantee_check_alarm").Rows
            drs = dsAlarm.Tables(0).Select("SerialNum=" & dr("serial_num") & " AND AlarmType='" & dr("alarm_type") & "'")
            If drs.Length > 0 Then
                drs(0)("Items") = drs(0)("Items") & "," & dr("AlarmName")
            Else
                Dim odr As DataRow = dsAlarm.Tables(0).NewRow
                With odr
                    .Item("SerialNum") = dr("serial_num")
                    .Item("AlarmType") = dr("alarm_type")
                    .Item("AlarmTypeName") = dsAlarmType.Tables(0).Select("alarm_type='" & dr("alarm_type") & "'")(0)("alarm_type_name")
                    .Item("Items") = dr("AlarmName")
                End With
                dsAlarm.Tables(0).Rows.Add(odr)
            End If
        Next
        If dsAlarm.HasChanges Then
            dsAlarm.AcceptChanges()
        End If
        dgDetail.DataSource = dsAlarm.Tables(0).DefaultView
        AddTableStyleOfDetail()
    End Sub
    Private Sub AddTableStyleOfDetail()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "AlarmTypeName"
        col1.HeaderText = "等级"
        col1.Width = 60
        col1.NullText = ""
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "Items"
        col2.HeaderText = "内容"
        col2.Width = 400
        col2.NullText = ""
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2})
        dgDetail.TableStyles.Add(dgts)
    End Sub
    Private Sub AddTableStyleOfHistory()
        dgRecord.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.AllowSorting = False
        dgts.MappingName = "guarantee_check_record"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "serial_num"
        col1.HeaderText = "检查次数"
        col1.Width = 55
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "check_date"
        col2.HeaderText = "检查日期"
        col2.Width = 70
        col2.Format = "yyyy-MM-dd"
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "finacial_report_month"
        col3.HeaderText = "依据的财务报表年月"
        col3.Width = 90
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "contact_person"
        col4.HeaderText = "贷款银行联系人"
        col4.NullText = ""
        col4.Width = 80
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "contact_phone"
        col5.HeaderText = "联系人电话"
        col5.NullText = ""
        col5.Width = 80
        '意见                                                                
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "approve_opinion"
        col7.HeaderText = "审核意见"
        col7.Width = 200
        col7.NullText = String.Empty
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.MappingName = "approve_person"
        col8.HeaderText = "审核人员"
        col8.Width = 80
        col8.NullText = String.Empty
        '确认人                                                         
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.MappingName = "approve_date"
        col9.HeaderText = "审核日期"
        col9.Width = 75
        col9.Format = "yyyy-MM-dd"
        col9.NullText = String.Empty
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col8, col9, col7})
        dgRecord.TableStyles.Add(dgts)
    End Sub

    '返回数据源

    Private Sub getOpinionDataSource()
        dsProAppraiseMent = New DataSet()
        dsProAppraiseMent = gWs.GetAppraisementInfo("{project_code='" & ProjectCode & "'}")
        btnDelete.Enabled = (dsProAppraiseMent.Tables(0).Rows.Count > 0)
        '"project_appraisement"
    End Sub

    Private Sub bm_positionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If bmRecord.Count = 0 Then Return
        CType(dgDetail.DataSource, DataView).RowFilter = "SerialNum=" & CType(bmRecord.Current, DataRowView)("serial_num").ToString
    End Sub

    Private Sub frmFollowManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If ProjectCode = String.Empty Then
                ProjectCode = MyBase.getProjectCode
                WorkFlowID = MyBase.getWorkFlowID
                TaskID = MyBase.getTaskID
                CorporationName = MyBase.getCorporationName
            Else
                btnNew.Visible = False
                btnDelete.Visible = False
                btnSave.Visible = False
                btnLookDocument.Visible = False
            End If
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName
            GetDataSourceOfShow()
            If bmRecord.Count = 0 Then Return
            dgRecord.DataMember = "guarantee_check_record"
            dgRecord.DataSource = dsRecord
            AddTableStyleOfHistory()
            bm_positionChanged(Nothing, Nothing)
            AddHandler bmRecord.PositionChanged, AddressOf bm_positionChanged

            SystemDate = gWs.GetSysTime
            '项目评价(风险部部长)
            OpinionSerialNum = gWs.GetMaxAppraisementNum(ProjectCode)
            getOpinionDataSource()
            'IniBindingsForOpinion()
            bmOpinion = BindingContext(dsProAppraiseMent, "project_appraisement")
            dgShow.DataMember = "project_appraisement"
            dgShow.DataSource = dsProAppraiseMent
            addTableStyleOpinion()
            AddHandler btnNew.Click, AddressOf NewEvent
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    ''''''''''样式表    
    Private Sub addTableStyleOpinion()
        dgShow.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "project_appraisement"
        '项目编码
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col1.MappingName = "project_code"
        col1.HeaderText = "项目编码"
        col1.Width = 0
        dgts.GridColumnStyles.Add(col1)
        '序号(隐藏)                                                   'index 1
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col11.MappingName = "serial_num"
        col11.Width = 0
        dgts.GridColumnStyles.Add(col11)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col2.MappingName = "create_date"
        col2.HeaderText = " 日期"
        col2.Width = 70
        col2.Format = "yyyy-MM-dd"
        col2.NullText = String.Empty
        col2.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col2)
        '贷款五级分类说明                              'index 4 
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "class_explanation"
        col7.HeaderText = "意见"
        col7.Width = 330
        col7.NullText = String.Empty
        col7.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col7)
        dgShow.TableStyles.Add(dgts)
    End Sub


    ''''''''''''项目评价  Begin''''''''''''''''''''''''
    Dim HasBinded As Boolean = False
    Private Sub IniBindingsForOpinion()
        dtpAuditDate.Value = SystemDate.Date
        dtpAuditDate.DataBindings.Add(New Binding("Value", dsProAppraiseMent, "project_appraisement.create_date"))
        txtRemark.DataBindings.Add(New Binding("Text", dsProAppraiseMent, "project_appraisement.class_explanation"))
        HasBinded = True
    End Sub
    Private Sub QuitBindingsForOpinion()
        dtpAuditDate.DataBindings.Clear()
        txtRemark.DataBindings.Clear()
        HasBinded = False
    End Sub

    Private Sub SetObjsEnabled(ByVal IsEnabled As Boolean)
        dtpAuditDate.Enabled = IsEnabled
        txtRemark.ReadOnly = Not IsEnabled
        btnSave.Enabled = IsEnabled
        dgShow.Enabled = Not IsEnabled
        If IsEnabled Then
            txtRemark.Text = String.Empty : dtpAuditDate.Value = SystemDate.Date
        End If
    End Sub

    Private Sub Cancel(ByVal sender As Object, ByVal e As EventArgs)
        If Not sender.GetType Is GetType(Button) Then Return

        If CType(sender, Button) Is btnNew And bmOpinion.Count = 1 Then
            QuitBindingsForOpinion() '去除绑定
        End If
        If dsProAppraiseMent.HasChanges Then
            dsProAppraiseMent.RejectChanges()
        End If

        SetObjsEnabled(False)
        btnDelete.Enabled = (dgShow.CurrentRowIndex >= 0)
        btnNew.Text = "新增(&N)" : strStatus = String.Empty
        RemoveHandler btnNew.Click, AddressOf Cancel
        AddHandler btnNew.Click, AddressOf NewEvent
        If dgShow.VisibleRowCount < bmOpinion.Count Then
            addTableStyleOpinion()
        End If
    End Sub

    Private Sub NewEvent(ByVal sender As Object, ByVal e As EventArgs)
        Dim dr As DataRow = dsProAppraiseMent.Tables(0).NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("serial_num") = OpinionSerialNum
            .Item("class") = "正常"
            .Item("create_person") = UserName
            .Item("create_date") = dtpAuditDate.Value.Date
        End With
        dsProAppraiseMent.Tables(0).Rows.Add(dr)
        OpinionSerialNum += 1 '移后了
        bmOpinion.Position = bmOpinion.Count - 1

        btnDelete.Enabled = False : strStatus = "new"
        If Not HasBinded Then
            IniBindingsForOpinion() '添加绑定        
        End If
        SetObjsEnabled(True)
        btnNew.Text = "取消(&N)"
        RemoveHandler btnNew.Click, AddressOf NewEvent
        AddHandler btnNew.Click, AddressOf Cancel
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If SWDialogBox.MessageBox.Show("?1004", "") = DialogResult.Yes Then
            If bmOpinion.Count = 1 Then
                QuitBindingsForOpinion()
            End If
            With dgShow
                dsProAppraiseMent.Tables(0).Select("serial_num=" & CInt(.Item(.CurrentRowIndex, 1)))(0).Delete()
                Dim strResult As String = gWs.UpdateAppraisement(dsProAppraiseMent.GetChanges(DataRowState.Deleted))
                If (strResult = "1") Then
                    dsProAppraiseMent.AcceptChanges()
                    SWDialogBox.MessageBox.Show("$DeleteSucceed")
                Else
                    SWDialogBox.MessageBox.Show("*999", "删除失败", strResult, "")
                End If
            End With
            If bmOpinion.Count = 0 Then
                IniBindingsForOpinion()
            End If
            btnDelete.Enabled = (dgShow.CurrentRowIndex >= 0)
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim diaResult As DialogResult = SWDialogBox.MessageBox.Show("?X007")
        bmOpinion.Position = bmOpinion.Count - 1
        Dim strResult As String = gWs.UpdateAppraisement(dsProAppraiseMent.GetChanges)
        If (strResult = "1") Then
            dsProAppraiseMent.AcceptChanges()
            If diaResult = DialogResult.Yes Then
                SendMessage()
            End If

            Dim dr As DataRow
            For Each dr In dsRecord.Tables("guarantee_check_record").Rows
                dr("hasAppraised") = True
            Next
            bmRecord.EndCurrentEdit()
            If dsRecord.HasChanges Then
                Dim result As String = gWs.UpdateCheckRecordAlarm(dsRecord.GetChanges)
                If result <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "保存表guarantee_check_record失败", result, "")
                Else
                    dsRecord.AcceptChanges()
                End If
            End If
            needRefresh = True
            If sender Is Nothing Then Return
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        Else
            SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
        End If
        Cancel(sender, e)
    End Sub
    Private Sub dgOpinion_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgShow.MouseUp
        With dgShow
            If .HitTest(e.X, e.Y).Type = DataGrid.HitTestType.RowHeader Then
                .UnSelect(.HitTest(e.X, e.Y).Row)
            End If
        End With

        With dgShow
            If .CurrentRowIndex < 0 Then
                Return
            End If
            .Select(.CurrentRowIndex)
            If Not HasBinded Then
                IniBindingsForOpinion()
            End If
        End With

    End Sub
    '提交成功后，发送消息给担保部长和项目经理A,B
    Private Sub SendMessage()
        Try
            Dim NowTime As DateTime = gWs.GetSysTime()
            Dim dsMessage As DataSet = gWs.LookUpMessage("{project_code LIKE '" & ProjectCode & "'}")

            Dim dr, odr As DataRow
            Dim dsStaff As DataSet = gWs.GetStaffByRoleID("21") '担保部长
            For Each odr In dsStaff.Tables(0).Rows
                dr = dsMessage.Tables(0).NewRow
                dr("project_code") = ProjectCode
                dr("message_content") = txtRemark.Text
                dr("responser") = UserName
                dr("accepter") = odr("staff_name")
                dr("send_time") = NowTime
                dr("is_affirmed") = "N"
                dsMessage.Tables(0).Rows.Add(dr)
            Next

            Dim dsProInfo As DataSet = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
            Dim ManagerA As String = String.Empty '项目经理A
            Dim ManagerB As String = String.Empty '项目经理B
            If dsProInfo.Tables(0).Rows.Count > 0 Then
                ManagerA = dsProInfo.Tables(0).Rows(0)("manager_A") & ""
                ManagerB = dsProInfo.Tables(0).Rows(0)("manager_B") & ""
            End If

            dr = dsMessage.Tables(0).NewRow
            dr("project_code") = ProjectCode
            dr("message_content") = txtRemark.Text
            dr("responser") = UserName
            dr("accepter") = ManagerA
            dr("send_time") = NowTime
            dr("is_affirmed") = "N"
            dsMessage.Tables(0).Rows.Add(dr)

            dr = dsMessage.Tables(0).NewRow
            dr("project_code") = ProjectCode
            dr("message_content") = txtRemark.Text
            dr("responser") = UserName
            dr("accepter") = ManagerB
            dr("send_time") = NowTime
            dr("is_affirmed") = "N"
            dsMessage.Tables(0).Rows.Add(dr)
            Dim result As String = gWs.UpdateMessage(dsMessage.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "发送消息失败", result, "")
            End If

            dsProInfo.Dispose()
            dsMessage.Dispose()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '''''''''''''项目评价  End'''''''''''''''''''''''''
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交") 'MessageBox.Show("请确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        If dsProAppraiseMent.HasChanges Then
            Dim strResult As String = gWs.UpdateAppraisement(dsProAppraiseMent.GetChanges)
            If strResult <> "1" Then Return
        End If
        Dim strSuccess As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If strSuccess = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            RemoveHandler MyBase.Closing, AddressOf frmProjectAppraisement_Closing
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strSuccess, "")
        End If
    End Sub

    Private Sub btnLookDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookDocument.Click
        Dim oForm As New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, "45", "003", UserName)
        oForm.setIsButtonEnable(True)
        oForm.AllowTransparency = False
        oForm.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub
    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If (strStatus <> String.Empty) Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003") 'MessageBox.Show("数据已修改，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If QueryResult = DialogResult.Yes Then
                btnSave_Click(Nothing, Nothing)
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frmProjectAppraisement_Closing
        Close()
        Return True
    End Function
    Private Sub frmProjectAppraisement_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub

    Private Sub frmProjectAppraisement_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If needRefresh Then
            MyBase.raiseCommitSucceed()
        End If
    End Sub

End Class
