Public Class frmNeedMeetProjectQuery
    Inherits Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgList As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNeedMeetProjectQuery))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgList = New System.Windows.Forms.DataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExit.Location = New System.Drawing.Point(584, 16)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "退出(&X)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgList})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 280)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dgList
        '
        Me.dgList.CaptionVisible = False
        Me.dgList.DataMember = ""
        Me.dgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgList.Location = New System.Drawing.Point(3, 17)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.Size = New System.Drawing.Size(674, 260)
        Me.dgList.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.dtpEnd, Me.dtpStart, Me.btnQuery, Me.btnExit})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 48)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "查询条件"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "截至日期"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "起始日期"
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(240, 16)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(112, 21)
        Me.dtpEnd.TabIndex = 5
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(64, 16)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(112, 21)
        Me.dtpStart.TabIndex = 4
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnQuery.Location = New System.Drawing.Point(504, 16)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.TabIndex = 1
        Me.btnQuery.Text = "查询(&Q)"
        '
        'frmNeedMeetProjectQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 341)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNeedMeetProjectQuery"
        Me.Text = "申请上会项目一览表"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private ws As htfServer.Service1
    Private dsProMeet As DataSet

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ws = gWs
        dsProMeet = New DataSet()
        AddTableStyle()
    End Sub


    Private Sub AddTableStyle()
        dgList.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        dgts.AllowSorting = False
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "SerialNo"                                      'index 0
        col5.HeaderText = "序号"
        col5.Alignment = HorizontalAlignment.Center
        col5.Width = 30
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()      'index 1
        col1.MappingName = "ProjectCode"
        col1.HeaderText = "项目编码"
        col1.Width = 65
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2
        col11.MappingName = "EnterpriseName"
        col11.HeaderText = "企业名称"
        col11.Width = 90
        col11.NullText = String.Empty
        col11.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col11)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 3 
        col2.MappingName = "TrialTimes"
        col2.HeaderText = "上会次数"
        col2.Alignment = HorizontalAlignment.Center
        col2.NullText = String.Empty
        col2.Width = 55
        dgts.GridColumnStyles.Add(col2)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 4  为删除dsConferenceTrial而设计
        col6.MappingName = "ServiceType"
        col6.HeaderText = "业务品种"
        col6.Width = 80
        col6.NullText = String.Empty
        col6.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col6)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col4.MappingName = "ApplyBank"
        col4.HeaderText = "申请贷款银行"
        col4.Alignment = HorizontalAlignment.Left
        col4.Width = 100
        col4.NullText = String.Empty
        dgts.GridColumnStyles.Add(col4)
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col8.MappingName = "ApplySum"
        col8.HeaderText = "申请金额(万元)"
        col8.Alignment = HorizontalAlignment.Left
        col8.Width = 90
        col8.Format = "c"
        col8.FormatInfo = CGFormatInfo
        col8.NullText = String.Empty
        dgts.GridColumnStyles.Add(col8)
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col9.MappingName = "ManagerA"
        col9.HeaderText = "项目经理A角"
        col9.Alignment = HorizontalAlignment.Left
        col9.Width = 70
        col9.NullText = String.Empty
        dgts.GridColumnStyles.Add(col9)
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col10.MappingName = "ManagerB"
        col10.HeaderText = "项目经理B角"
        col10.Alignment = HorizontalAlignment.Left
        col10.Width = 70
        col10.NullText = String.Empty
        dgts.GridColumnStyles.Add(col10)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 5
        col3.MappingName = "ApplyMeetDate"
        col3.HeaderText = "申请上会日期"
        col3.Width = 90
        col3.Format = "yyyy-MM-dd"
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col3)
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        col7.MappingName = "ConferenceDate"
        col7.HeaderText = "上会日期"
        col7.Width = 70
        col7.Format = "yyyy-MM-dd"
        col7.NullText = String.Empty
        col7.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col7)
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        col12.MappingName = "Conclusion"
        col12.HeaderText = "评审意见"
        col12.Width = 65
        col12.NullText = String.Empty
        col12.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col12)
        dgList.TableStyles.Add(dgts)
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private IsChanged As Boolean = True
    Private Sub btnQuery_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuery.Click
        If IsChanged Then
            dsProMeet = ws.GetMeetProject(dtpStart.Value.Date, dtpEnd.Value.Date)
            dgList.DataMember = "Table"
            dgList.DataSource = dsProMeet
            IsChanged = False
        End If
    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpStart.ValueChanged
        IsChanged = True
    End Sub

    Private Sub dtpEnd_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpEnd.ValueChanged
        IsChanged = True
    End Sub
End Class
