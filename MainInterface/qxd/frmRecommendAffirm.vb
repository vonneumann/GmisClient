

Public Class frmRecommendAffirm
    Inherits MainInterface.frmBasic

    Private strWorkFlowID As String
    Private strProjectCode As String
    Private strCorporationName As String
    Private strTaskID As String
    Private strPerson As String
    Private strPhase As String

    Private strItemType As String = "44"
    Private strItemCode As String = "010"

    Private Const STREXEMPT As String = "豁免"

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
    Friend WithEvents btnConclusion As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbRecommend As System.Windows.Forms.ComboBox
    Friend WithEvents txtRecomMoney As System.Windows.Forms.TextBox
    Friend WithEvents txtRecomOpinion As System.Windows.Forms.TextBox
    Friend WithEvents dateRecom As System.Windows.Forms.DateTimePicker
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkExempt As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRecommendAffirm))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnConclusion = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dateRecom = New System.Windows.Forms.DateTimePicker()
        Me.txtRecomOpinion = New System.Windows.Forms.TextBox()
        Me.txtRecomMoney = New System.Windows.Forms.TextBox()
        Me.cmbRecommend = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkExempt = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(360, 232)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(273, 232)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 1
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConclusion
        '
        Me.btnConclusion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConclusion.Image = CType(resources.GetObject("btnConclusion.Image"), System.Drawing.Bitmap)
        Me.btnConclusion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConclusion.ImageIndex = 25
        Me.btnConclusion.ImageList = Me.ImageListBasic
        Me.btnConclusion.Location = New System.Drawing.Point(159, 232)
        Me.btnConclusion.Name = "btnConclusion"
        Me.btnConclusion.Size = New System.Drawing.Size(104, 24)
        Me.btnConclusion.TabIndex = 0
        Me.btnConclusion.Text = "评审会结论(&R)"
        Me.btnConclusion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dateRecom, Me.txtRecomOpinion, Me.txtRecomMoney, Me.cmbRecommend, Me.Label7, Me.Label6, Me.Label5, Me.Label4})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 184)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "推荐信息"
        '
        'dateRecom
        '
        Me.dateRecom.Location = New System.Drawing.Point(80, 48)
        Me.dateRecom.Name = "dateRecom"
        Me.dateRecom.Size = New System.Drawing.Size(152, 21)
        Me.dateRecom.TabIndex = 13
        '
        'txtRecomOpinion
        '
        Me.txtRecomOpinion.Location = New System.Drawing.Point(80, 80)
        Me.txtRecomOpinion.MaxLength = 250
        Me.txtRecomOpinion.Multiline = True
        Me.txtRecomOpinion.Name = "txtRecomOpinion"
        Me.txtRecomOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecomOpinion.Size = New System.Drawing.Size(488, 96)
        Me.txtRecomOpinion.TabIndex = 12
        Me.txtRecomOpinion.Text = ""
        '
        'txtRecomMoney
        '
        Me.txtRecomMoney.Location = New System.Drawing.Point(368, 19)
        Me.txtRecomMoney.Name = "txtRecomMoney"
        Me.txtRecomMoney.Size = New System.Drawing.Size(200, 21)
        Me.txtRecomMoney.TabIndex = 11
        Me.txtRecomMoney.Text = ""
        '
        'cmbRecommend
        '
        Me.cmbRecommend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecommend.Enabled = False
        Me.cmbRecommend.Location = New System.Drawing.Point(80, 19)
        Me.cmbRecommend.Name = "cmbRecommend"
        Me.cmbRecommend.Size = New System.Drawing.Size(152, 20)
        Me.cmbRecommend.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "推荐日期"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "推荐意见"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "推荐金额(万元)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "合作区名称"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(328, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(256, 21)
        Me.txtName.TabIndex = 12
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(272, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(168, 21)
        Me.txtCode.TabIndex = 10
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkExempt
        '
        Me.chkExempt.Location = New System.Drawing.Point(16, 232)
        Me.chkExempt.Name = "chkExempt"
        Me.chkExempt.Size = New System.Drawing.Size(48, 21)
        Me.chkExempt.TabIndex = 15
        Me.chkExempt.Text = "豁免"
        '
        'frmRecommendAffirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(596, 263)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkExempt, Me.txtName, Me.Label2, Me.txtCode, Me.Label1, Me.GroupBox2, Me.btnConclusion, Me.btnCommit, Me.btnExit})
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecommendAffirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "合作区推荐(专管员)"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmRecommendAffirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser()
        Me.strPhase = getPhase(strProjectCode)

        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName

        'qxd add 2003-12-17
        setCmbRecommend()
        setRecommendInfo()

        Me.setChkExempt() '设置豁免的初始值
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
       
        If Not Me.addAffirmRecord Then
            Exit Sub
        End If
        '保存合作区推荐信息
        If Not Me.saveRecommendInfo() Then
            Exit Sub
        End If

        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
            If "1" = strCommit Then
                'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                raiseCommitSucceed()
                Me.Close()
            Else
                'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConclusion.Click
        If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count <= 0 Then
            '显示“无效或没有可供操作的数据”消息框
            SWDialogBox.MessageBox.Show("$1005", " 评审会结论 ")
            Return
        End If

        Dim meet As New frmMeetRecordQuery(strProjectCode, strCorporationName)
        meet.ShowDialog()
    End Sub

    
    '
    '确认时,若记录已经存在,则修改确认记录;否则新增一条记录
    '保存在表project_document中
    '
    Private Function addAffirmRecord() As Boolean
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strResult As String
        Try
            ds = gWs.GetProjectDocumentByCondition("{project_code='" & Me.strProjectCode & "' and item_type='" & Me.strItemType & "' and item_code='" & Me.strItemCode & "'}")
        Catch ex As Exception
            'MsgBox("获取project_document时出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        If ds Is Nothing Then
            Return False
        End If

        i = ds.Tables("TProjectDocument").Rows.Count

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
                If Me.chkExempt.Checked Then
                    .Item("remark") = Me.STREXEMPT
                Else
                    .Item("remark") = ""
                End If
            End With
        Else
            dr = ds.Tables("TProjectDocument").NewRow
            With dr
                .Item("project_code") = strProjectCode
                .Item("phase") = strPhase
                .Item("item_type") = Me.strItemType
                .Item("item_code") = Me.strItemCode
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
                If Me.chkExempt.Checked Then
                    .Item("remark") = Me.STREXEMPT
                Else
                    .Item("remark") = ""
                End If
            End With
            ds.Tables("TProjectDocument").Rows.Add(dr)
        End If

        strResult = gWs.UpdateProjectDocument(ds)
        If strResult = "1" Then
            Return True
        Else
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            Return False
        End If
    End Function
   
    'qxd add 2003-12-17---------------------------------------------------------------------------
    '获得合作区推荐的信息
    Private Sub setRecommendInfo()
        Dim i, count As Integer
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strSql As String

        Try
            strSql = "{project_code='" & strProjectCode & "'}"
            ds = gWs.GetCooperateOrganizationOpinion(strSql)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                If count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        Me.cmbRecommend.SelectedValue = IIf(.Item("cooperate_organization") Is System.DBNull.Value, System.DBNull.Value, .Item("cooperate_organization"))
                        Me.txtRecomMoney.Text = IIf(.Item("recommend_sum") Is System.DBNull.Value, "", .Item("recommend_sum"))
                        If Not .Item("recommend_date") Is System.DBNull.Value Then
                            Me.dateRecom.Value = .Item("recommend_date")
                        End If
                        Me.txtRecomOpinion.Text = IIf(.Item("opinion") Is System.DBNull.Value, "", .Item("opinion"))
                        Me.chkExempt.Checked = IIf(.Item("exempt") Is System.DBNull.Value, False, .Item("exempt"))
                    End With
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '初始化推荐区下拉框
    Private Sub setCmbRecommend()
        Dim ds As DataSet

        Try
            ds = gWs.GetCooperateOrganization("%")
            Me.cmbRecommend.DataSource = ds.Tables(0)
            Me.cmbRecommend.DisplayMember = "cooperate_organization"
            Me.cmbRecommend.ValueMember = "cooperate_organization"
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '保存合作区推荐信息
    Private Function saveRecommendInfo() As Boolean
        Dim i, count As Integer
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strSql As String
        Dim strResult As String

        Try
            strSql = "{project_code='" & strProjectCode & "'}"
            ds = gWs.GetCooperateOrganizationOpinion(strSql)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                If count > 0 Then '修改
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        .Item("cooperate_organization") = Me.cmbRecommend.SelectedValue
                        '2005-03-22 yjf modify 修改推荐金额，可不输入金额（保存为空）
                        If Me.txtRecomMoney.Text.Trim = "" Then
                            .Item("recommend_sum") = DBNull.Value
                        Else
                            .Item("recommend_sum") = Me.txtRecomMoney.Text
                        End If
                        .Item("recommend_date") = Me.dateRecom.Value
                        .Item("opinion") = Me.txtRecomOpinion.Text
                        .Item("exempt") = Me.chkExempt.Checked
                    End With
                Else '新增
                    'dr = ds.Tables(0).NewRow
                    'With dr
                    '    .Item("project_code") = Me.strProjectCode
                    '    .Item("cooperate_organization") = Me.cmbRecommend.SelectedValue
                    '    .Item("recommend_sum") = Me.txtRecomMoney.Text
                    '    .Item("recommend_date") = Me.dateRecom.Value
                    '    .Item("opinion") = Me.txtRecomOpinion.Text
                    '    .Item("create_person") = Me.getUser
                    '    .Item("create_date") = gWs.GetSysTime()
                    'End With
                    'ds.Tables(0).Rows.Add(dr)
                End If
                strResult = gWs.UpdateCooperateOrganizationOpinion(ds)
                If strResult = "1" Then
                    Return True
                Else
                    SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    Return False
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '设置豁免chbExempt的初始值
    Private Sub setChkExempt()
        Dim strSql As String = "{project_code='" & Me.strProjectCode & "' and item_type='" & Me.strItemType & "' and item_code='" & Me.strItemCode & "'}"
        Dim ds As DataSet
        Try
            ds = gWs.GetProjectDocumentByCondition(strSql)
            If Not ds Is Nothing Then
                Dim i As Int16 = ds.Tables("TProjectDocument").Rows.Count
                If i > 0 Then
                    If Not ds.Tables("TProjectDocument").Rows(0).Item("remark") Is System.DBNull.Value Then
                        If ds.Tables("TProjectDocument").Rows(0).Item("remark") = Me.STREXEMPT Then
                            Me.chkExempt.Checked = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
End Class
