Public Class frmDefectRecordAdd
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCorporationCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dDefectDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Public WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDefectRecordAdd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dDefectDate = New System.Windows.Forms.DateTimePicker
        Me.txtSource = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCorporationName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCorporationCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dDefectDate)
        Me.GroupBox1.Controls.Add(Me.txtSource)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCorporationName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCorporationCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "新增企业失信记录"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(80, 120)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(456, 88)
        Me.txtDescription.TabIndex = 10
        Me.txtDescription.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Tag = ""
        Me.Label5.Text = "信息描述"
        '
        'dDefectDate
        '
        Me.dDefectDate.Location = New System.Drawing.Point(80, 88)
        Me.dDefectDate.Name = "dDefectDate"
        Me.dDefectDate.Size = New System.Drawing.Size(152, 21)
        Me.dDefectDate.TabIndex = 8
        '
        'txtSource
        '
        Me.txtSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSource.Location = New System.Drawing.Point(352, 88)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(184, 21)
        Me.txtSource.TabIndex = 7
        Me.txtSource.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(288, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Tag = ""
        Me.Label4.Text = "信息来源"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Tag = ""
        Me.Label3.Text = "失信日期"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorporationName.Enabled = False
        Me.txtCorporationName.Location = New System.Drawing.Point(80, 56)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(456, 21)
        Me.txtCorporationName.TabIndex = 3
        Me.txtCorporationName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Tag = ""
        Me.Label2.Text = "企业名称"
        '
        'txtCorporationCode
        '
        Me.txtCorporationCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorporationCode.Location = New System.Drawing.Point(80, 24)
        Me.txtCorporationCode.Name = "txtCorporationCode"
        Me.txtCorporationCode.Size = New System.Drawing.Size(456, 21)
        Me.txtCorporationCode.TabIndex = 1
        Me.txtCorporationCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = ""
        Me.Label1.Text = "企业编码"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(480, 232)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Enabled = False
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(304, 232)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageIndex = 13
        Me.btnAdd.ImageList = Me.ImageListBasic
        Me.btnAdd.Location = New System.Drawing.Point(216, 232)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "新 增(&A)"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Enabled = False
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 8
        Me.btnCancel.ImageList = Me.ImageListBasic
        Me.btnCancel.Location = New System.Drawing.Point(392, 232)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(77, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "取 消(&C)"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDefectRecordAdd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(568, 266)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDefectRecordAdd"
        Me.Text = "企业失信记录新增"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub frmDefectRecordAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtCorporationCode.Enabled = False
        dDefectDate.Enabled = False
        txtSource.Enabled = False
        txtDescription.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtCorporationCode.Enabled = True
        dDefectDate.Enabled = True
        txtSource.Enabled = True
        txtDescription.Enabled = True

        txtCorporationCode.Text = ""
        dDefectDate.Text = ""
        txtSource.Text = ""
        txtDescription.Text = ""

        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        txtCorporationCode.Enabled = False
        dDefectDate.Enabled = False
        txtSource.Enabled = False
        txtDescription.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True

        Dim dsDefectRecord As DataSet
        dsDefectRecord = gWs.GetCorpDefectInfo("{guid is null}")

        If GetCorporationName(Trim(txtCorporationCode.Text)) <> "" Then

            Dim dr As DataRow = dsDefectRecord.Tables(0).NewRow
            With dr
                .Item("guid") = Guid.NewGuid()
                .Item("corporation_code") = txtCorporationCode.Text
                .Item("corporation_name") = txtCorporationName.Text
                .Item("DiscreditableDate") = dDefectDate.Value.ToShortDateString
                .Item("source") = txtSource.Text
                .Item("description") = txtDescription.Text
                .Item("create_person") = UserName
                .Item("create_date") = Now.Today
            End With
            dsDefectRecord.Tables(0).Rows.Add(dr)

            Dim strResult As String = gWs.UpdateCorpDefect(dsDefectRecord)
            If (strResult = "1") Then
                SWDialogBox.MessageBox.Show("$SaveSucceed")
            Else
                SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
            End If
        Else
            MsgBox("无法找到指定企业编码的企业名称", MsgBoxStyle.Information, "提示")
        End If


    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtCorporationCode.Enabled = False
        dDefectDate.Enabled = False
        txtSource.Enabled = False
        txtDescription.Enabled = False
        btnSave.Enabled = False

        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
    End Sub

    Private Sub txtCorporationCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCorporationCode.Leave
        Dim strCorporationName As String = GetCorporationName(Trim(txtCorporationCode.Text))
        txtCorporationName.Text = strCorporationName
    End Sub

    Private Function GetCorporationName(ByVal corporationCode As String) As String
        Dim ds As DataSet = gWs.GetcorporationInfo("{corporation_code='" & corporationCode & "'}", "")
        If ds.Tables(0).Rows.Count <> 0 Then
            Return ds.Tables(0).Rows(0).Item("corporation_name")
        Else
            Return ""
        End If
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
