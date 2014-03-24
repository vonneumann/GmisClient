Public Class frmSigProject
    Inherits Form

    Private ProjectList As String
    Private Address As String
    Private PlanDate As String
    Private SignCode As Integer
    Private dsSig As DataSet
    Private dsSigPro As DataSet  'real DataSet
    Private dsShow As DataSet    'show DataSet
    Private dsCollection As DataSet  'rubbish CallBack
    Private bmShow As BindingManagerBase  'dglist
    Private bmCol As BindingManagerBase  'dgshow
    Private SystemDate As Date
    Private HasArranged As Boolean
    Private NPL, OldPl, NewPl As String

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    Public Sub New(ByVal _PlanDate As String, ByVal _address As String, ByVal Pl As String, ByVal _SignCode As Integer, ByVal _HasArranged As Boolean)
        MyBase.New()
        InitializeComponent()
        PlanDate = _PlanDate
        Address = _address
        NPL = Pl
        SignCode = _SignCode
        HasArranged = _HasArranged
    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsCollection Is Nothing Then
            dsCollection.Dispose()
        End If
        If Not dsShow Is Nothing Then
            dsShow.Dispose()
        End If
        If Not dsSig Is Nothing Then
            dsSig.Dispose()
        End If
        If Not dsSigPro Is Nothing Then
            dsSigPro.Dispose()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents gpbxMeeting As System.Windows.Forms.GroupBox
    Friend WithEvents dgList As System.Windows.Forms.DataGrid
    Friend WithEvents dgSig As System.Windows.Forms.DataGrid
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlanDate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSigProject))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgList = New System.Windows.Forms.DataGrid()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.gpbxMeeting = New System.Windows.Forms.GroupBox()
        Me.dgSig = New System.Windows.Forms.DataGrid()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlanDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxMeeting.SuspendLayout()
        CType(Me.dgSig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgList})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 168)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "需要签约项目一览表"
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
        Me.dgList.Size = New System.Drawing.Size(682, 148)
        Me.dgList.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(356, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.Location = New System.Drawing.Point(268, 384)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 2
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpbxMeeting
        '
        Me.gpbxMeeting.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxMeeting.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgSig})
        Me.gpbxMeeting.Location = New System.Drawing.Point(8, 216)
        Me.gpbxMeeting.Name = "gpbxMeeting"
        Me.gpbxMeeting.Size = New System.Drawing.Size(688, 160)
        Me.gpbxMeeting.TabIndex = 41
        Me.gpbxMeeting.TabStop = False
        Me.gpbxMeeting.Text = "安排签约项目一览表"
        '
        'dgSig
        '
        Me.dgSig.CaptionVisible = False
        Me.dgSig.DataMember = ""
        Me.dgSig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSig.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgSig.Location = New System.Drawing.Point(3, 17)
        Me.dgSig.Name = "dgSig"
        Me.dgSig.ReadOnly = True
        Me.dgSig.Size = New System.Drawing.Size(682, 140)
        Me.dgSig.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAddress.Location = New System.Drawing.Point(264, 8)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(376, 21)
        Me.txtAddress.TabIndex = 47
        Me.txtAddress.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(200, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "签约地点"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPlanDate
        '
        Me.txtPlanDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPlanDate.Location = New System.Drawing.Point(96, 8)
        Me.txtPlanDate.Name = "txtPlanDate"
        Me.txtPlanDate.ReadOnly = True
        Me.txtPlanDate.Size = New System.Drawing.Size(96, 21)
        Me.txtPlanDate.TabIndex = 45
        Me.txtPlanDate.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "计划签约日期"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSigProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(704, 413)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAddress, Me.Label3, Me.txtPlanDate, Me.Label2, Me.gpbxMeeting, Me.btnCommit, Me.btnExit, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSigProject"
        Me.Text = "安排项目签约"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxMeeting.ResumeLayout(False)
        CType(Me.dgSig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            txtPlanDate.Text = PlanDate
            txtAddress.Text = Address

            If NPL.Trim = String.Empty Then
                SWDialogBox.MessageBox.Show("$X040")
                'MessageBox.Show("没有要签约的项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCommit.Enabled = False
                Return
            End If
            SystemDate = gWs.GetSysTime
            dsSig = gWs.GetSignaturePlanInfo("{(signature_plan_code=" & SignCode & ")}")
            dsSigPro = gWs.GetProjectSignatureInfo("{(signature_plan_code=" & SignCode & ") OR (project_code IN (" & NPL & "))}")
            Dim dr As DataRow
            For Each dr In dsSigPro.Tables(0).Select("signature_plan_code=" & SignCode)
                OldPl += "'" & CStr(dr("project_code")) & "',"
            Next

            OldPl = MyIIf(OldPl, GetType(String), "'',")
            OldPl = OldPl.Substring(0, OldPl.Length - 1)
            dsShow = gWs.GetProjectInfoEx("{ProjectCode IN (" & NPL & ") OR ProjectCode IN (" & OldPl & ")}")
            dgList.DataMember = "ViewProject"
            dgList.DataSource = dsShow
            bmShow = BindingContext(dsShow, "ViewProject")
            AddTableStyle(dgList, "ViewProject")
            dsCollection = New DataSet()
            dsCollection = dsShow.Clone
            dgSig.DataMember = "ViewProject"
            dgSig.DataSource = dsCollection
            bmCol = BindingContext(dsCollection, "ViewProject")
            AddTableStyle(dgSig, "ViewProject")
            For Each dr In dsSigPro.Tables(0).Select("signature_plan_code=" & SignCode)
                dsCollection.Tables(0).ImportRow(dsShow.Tables(0).Select("ProjectCode LIKE '" & CStr(dr("project_code")) & "'")(0))
                dsShow.Tables(0).Rows.Remove(dsShow.Tables(0).Select("ProjectCode LIKE '" & CStr(dr("project_code")) & "'")(0))
            Next

            AddHandler dgList.DoubleClick, AddressOf DataGridDoubleClickHandler
            AddHandler dgSig.DoubleClick, AddressOf DataGridDoubleClickHandler
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub AddTableStyle(ByVal DataGrid As DataGrid, ByVal TableName As String)
        DataGrid.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = TableName
        dgts.AllowSorting = False
        'dgts.RowHeadersVisible = False
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()      'index 1
        col1.MappingName = "ProjectCode"
        col1.HeaderText = "项目编码"
        col1.Width = 65
        col1.Alignment = HorizontalAlignment.Left
        col1.TextBox.Tag = DataGrid
        AddHandler col1.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col1)
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2
        col11.MappingName = "EnterpriseName"
        col11.HeaderText = "企业名称"
        col11.Width = 90
        col11.NullText = String.Empty
        col11.Alignment = HorizontalAlignment.Left
        col11.TextBox.Tag = DataGrid
        AddHandler col11.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        'AddHandler col11.TextBox.DoubleClick, AddressOf TextBoxDoubleClickHandler
        dgts.GridColumnStyles.Add(col11)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 4  为删除dsConferenceTrial而设计
        col6.MappingName = "ServiceType"
        col6.HeaderText = "业务品种"
        col6.Width = 80
        col6.NullText = String.Empty
        col6.Alignment = HorizontalAlignment.Left
        col6.TextBox.Tag = DataGrid
        AddHandler col6.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        'AddHandler col6.TextBox.DoubleClick, AddressOf TextBoxDoubleClickHandler
        dgts.GridColumnStyles.Add(col6)
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col8.MappingName = "GuaranteeSum"
        col8.HeaderText = "贷款金额(万元)"
        col8.Alignment = HorizontalAlignment.Right
        col8.Width = 95
        col8.Format = "c"
        col8.FormatInfo = CGFormatInfo
        col8.NullText = String.Empty
        col8.TextBox.Tag = DataGrid
        AddHandler col8.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        'AddHandler col8.TextBox.DoubleClick, AddressOf TextBoxDoubleClickHandler
        dgts.GridColumnStyles.Add(col8)
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        col12.MappingName = "RefundType"
        col12.HeaderText = "还款方式"
        col12.Width = 80
        col12.NullText = String.Empty
        col12.Alignment = HorizontalAlignment.Left
        col12.TextBox.Tag = DataGrid
        AddHandler col12.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        'AddHandler col12.TextBox.DoubleClick, AddressOf TextBoxDoubleClickHandler
        dgts.GridColumnStyles.Add(col12)
        Dim co3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        co3.MappingName = "BankName"
        co3.HeaderText = "贷款银行"
        co3.Width = 90
        co3.NullText = String.Empty
        co3.Alignment = HorizontalAlignment.Left
        co3.TextBox.Tag = DataGrid
        AddHandler co3.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        'AddHandler co3.TextBox.DoubleClick, AddressOf TextBoxDoubleClickHandler
        dgts.GridColumnStyles.Add(co3)
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col9.MappingName = "manager_A"
        col9.HeaderText = "项目经理A角"
        col9.Alignment = HorizontalAlignment.Left
        col9.Width = 75
        col9.NullText = String.Empty
        col9.TextBox.Tag = DataGrid
        AddHandler col9.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        'AddHandler col9.TextBox.DoubleClick, AddressOf TextBoxDoubleClickHandler
        dgts.GridColumnStyles.Add(col9)
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col10.MappingName = "law_manager"
        col10.HeaderText = "法务经理"
        col10.Alignment = HorizontalAlignment.Left
        col10.Width = 60
        col10.NullText = String.Empty
        col10.TextBox.Tag = DataGrid
        AddHandler col10.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        'AddHandler col10.TextBox.DoubleClick, AddressOf TextBoxDoubleClickHandler
        dgts.GridColumnStyles.Add(col10)
        DataGrid.TableStyles.Add(dgts)
    End Sub

    Private Function RollbackSomeProjects() As Boolean
        If Not HasArranged Then Return True
        If OldPl Is Nothing Then Return True

        Dim dr As DataRow
        For Each dr In dsSigPro.Tables(0).Select("signature_plan_code=" & SignCode)
            NewPl += "'" & CStr(dr("project_code")) & "',"
        Next
        Dim eachPC As String = ""
        Dim result As String
        For Each eachPC In OldPl.Split(",")
            If eachPC.Trim <> String.Empty And eachPC <> "''" Then
                If NewPl.IndexOf(eachPC) < 0 Then
                    eachPC = eachPC.Replace("'", String.Empty)
                    result = gWs.CancelSignaturePlanProject(eachPC.Trim)
                    If result <> "1" Then
                        SWDialogBox.MessageBox.Show("$X041", eachPC)
                        'MessageBox.Show("项目：" & eachPC & "回退失败" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                End If
            End If
        Next
        Return True
    End Function

    Private Sub DoSomething(ByVal sender As DataGrid)
        If CType(sender.DataSource, DataSet).Tables(0).Rows.Count = 0 Then Return

        If sender Is dgList Then  'bmShow
            dsCollection.Tables(0).ImportRow(dsShow.Tables(0).Rows(sender.CurrentRowIndex))
            If dsCollection.HasChanges Then
                dsCollection.AcceptChanges()
            End If
            dsShow.Tables(0).Rows.RemoveAt(sender.CurrentRowIndex)
        ElseIf sender Is dgSig Then                                       'bmCol
            dsShow.Tables(0).ImportRow(dsCollection.Tables(0).Rows(sender.CurrentRowIndex))
            If dsShow.HasChanges Then
                dsShow.AcceptChanges()
            End If
            dsCollection.Tables(0).Rows.RemoveAt(sender.CurrentRowIndex)
        End If
    End Sub

    Private Sub TextBoxMouseDownHandler(ByVal sender As Object, ByVal e As MouseEventArgs)
        DoSomething(CType(CType(sender, TextBox).Tag, DataGrid))
    End Sub
    Private Sub DataGridDoubleClickHandler(ByVal sender As Object, ByVal e As EventArgs)
        DoSomething(CType(sender, DataGrid))
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If dgSig.CurrentRowIndex < 0 Then
            SWDialogBox.MessageBox.Show("$X042")
            'MessageBox.Show("没有项目安排到该签约计划，不能提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If CType(Me.Owner, frmArrangeSign).isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        Dim dr As DataRow
        For Each dr In dsSigPro.Tables(0).Rows
            dr("signature_plan_code") = DBNull.Value
        Next
        Dim drs As DataRow()
        For Each dr In dsCollection.Tables(0).Rows
            drs = dsSigPro.Tables(0).Select("project_code = '" & CStr(dr("ProjectCode")) & "'")
            If drs.Length > 0 Then
                drs(0)("signature_plan_code") = SignCode
            Else
                Dim ndr As DataRow = dsSigPro.Tables(0).NewRow
                With ndr
                    .Item("project_code") = CStr(dr("ProjectCode"))
                    .Item("signature_plan_code") = SignCode
                    .Item("create_person") = UserName
                    .Item("create_date") = SystemDate.Date
                End With
                dsSigPro.Tables(0).Rows.Add(ndr)
            End If
        Next
        If Not RollbackSomeProjects() Then Return '回退项目失败则返回
        Dim strResult As String = gWs.UpdateProjectSignature(dsSigPro.GetChanges)
        If (strResult <> "1") Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
        Else
            dsSigPro.AcceptChanges()
        End If

        strResult = gWs.FinishedSignaturePlan(SignCode)
        If strResult = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            If Not HasArranged Then
                dsSig.Tables(0).Rows(0)("status") = "已提交"
                If gWs.UpdateSignaturePlan(dsSig.GetChanges) <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "签约状态保存出错", "", "")
                End If
            End If
            CType(Me.Owner, frmArrangeSign).IsOwnedFormCommit = True
            CType(Me.Owner, frmArrangeSign).raiseCommitSucceed()
            Me.Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "")
            'MessageBox.Show("提交失败" & vbCr & strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
