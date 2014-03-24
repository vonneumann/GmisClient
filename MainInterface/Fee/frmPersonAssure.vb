Public Class frmPersonAssure
    Inherits System.Windows.Forms.Form
    Private ProjectCode As String
    Private CorporationName As String
    Private dsPerson As DataSet
    Private SystemDate As Date

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    Public Sub New(ByVal _ProjectCode As String, ByVal _CorporationName As String)
        MyBase.New()
        InitializeComponent()
        ProjectCode = _ProjectCode
        CorporationName = _CorporationName
    End Sub
    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsPerson Is Nothing Then
            dsPerson.Dispose()
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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIDCard As System.Windows.Forms.TextBox
    Friend WithEvents cmbxMan As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents rbtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPersonAssure))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.cmbxMan = New System.Windows.Forms.ComboBox()
        Me.txtIDCard = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(384, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(304, 272)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(240, 5)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 28
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 5)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectCode.TabIndex = 27
        Me.txtProjectCode.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "企业名称"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "项目编码"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtMaterial, Me.Label2, Me.rbtnFemale, Me.rbtnMale, Me.cmbxMan, Me.txtIDCard, Me.Label8, Me.txtAddress, Me.Label7, Me.txtPhone, Me.Label4, Me.txtAge, Me.Label3, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 232)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(80, 96)
        Me.txtMaterial.MaxLength = 1000
        Me.txtMaterial.Multiline = True
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(400, 128)
        Me.txtMaterial.TabIndex = 41
        Me.txtMaterial.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "资 产 清 单"
        '
        'rbtnFemale
        '
        Me.rbtnFemale.Location = New System.Drawing.Point(224, 15)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(32, 18)
        Me.rbtnFemale.TabIndex = 1
        Me.rbtnFemale.Text = "女"
        '
        'rbtnMale
        '
        Me.rbtnMale.Checked = True
        Me.rbtnMale.Location = New System.Drawing.Point(184, 15)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(32, 18)
        Me.rbtnMale.TabIndex = 1
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "男"
        '
        'cmbxMan
        '
        Me.cmbxMan.Location = New System.Drawing.Point(80, 14)
        Me.cmbxMan.MaxLength = 10
        Me.cmbxMan.Name = "cmbxMan"
        Me.cmbxMan.Size = New System.Drawing.Size(88, 20)
        Me.cmbxMan.TabIndex = 0
        '
        'txtIDCard
        '
        Me.txtIDCard.Location = New System.Drawing.Point(80, 40)
        Me.txtIDCard.MaxLength = 20
        Me.txtIDCard.Name = "txtIDCard"
        Me.txtIDCard.Size = New System.Drawing.Size(88, 21)
        Me.txtIDCard.TabIndex = 3
        Me.txtIDCard.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 14)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "身份证号码"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(80, 67)
        Me.txtAddress.MaxLength = 30
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(400, 21)
        Me.txtAddress.TabIndex = 5
        Me.txtAddress.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 14)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "住     址"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(248, 40)
        Me.txtPhone.MaxLength = 15
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(96, 21)
        Me.txtPhone.TabIndex = 4
        Me.txtPhone.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "联系电话"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(312, 14)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(32, 21)
        Me.txtAge.TabIndex = 2
        Me.txtAge.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 14)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "年 龄"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "姓     名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(224, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPersonAssure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(504, 303)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDelete, Me.GroupBox1, Me.btnSave, Me.btnExit, Me.Label5, Me.txtCorName, Me.txtProjectCode, Me.Label6})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersonAssure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "个人保证信息"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GetDataSource()
        dsPerson = gWs.GetOppositeGuaranteeAssurerInfo("{project_code LIKE '" & ProjectCode & "'}")
        cmbxMan.Items.Clear()
        Dim dr As DataRow
        For Each dr In dsPerson.Tables(0).Rows
            If Not IsDBNull(dr("name")) Then
                cmbxMan.Items.Add(dr("name"))
            End If
        Next
        cmbxMan.Text = String.Empty
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName
            SystemDate = gWs.GetSysTime
            GetDataSource()
        Catch ex As Exception
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ExceptionHandler.ShowMessageBox(ex)
            btnSave.Enabled = False
        End Try
        Me.AllowTransparency = False
    End Sub

    Private Sub frm_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            CType(sender, Form).SelectNextControl(Me.ActiveControl, True, False, True, True)
        End If
    End Sub

    Private Sub cmbxMan_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxMan.TextChanged
        btnSave.Enabled = cmbxMan.Text <> String.Empty
        Dim inx As Int32 = cmbxMan.FindStringExact(cmbxMan.Text)
        btnDelete.Enabled = inx > -1
        If Not btnDelete.Enabled Then
            txtAddress.Text = String.Empty : txtAge.Text = String.Empty
            txtPhone.Text = String.Empty : txtIDCard.Text = String.Empty
            txtMaterial.Text = String.Empty
            Return
        End If
        With dsPerson.Tables(0).Rows(inx)
            If CStr(.Item("sex")) = "男" Then
                rbtnMale.Checked = True
            Else
                rbtnFemale.Checked = True
            End If
            txtAddress.Text = .Item("address") & String.Empty
            txtAge.Text = .Item("age") & String.Empty
            txtPhone.Text = .Item("phone") & String.Empty
            txtIDCard.Text = .Item("IC_code") & String.Empty
            txtMaterial.Text = .Item("assets_bill") & String.Empty
        End With
    End Sub

    Private Sub cmbxMan_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxMan.Leave
        cmbxMan_TextChanged(sender, e)
        cmbxMan.Text = cmbxMan.Text.Replace("%", "")
    End Sub

    Private Sub CopyValue(ByVal dr As DataRow)
        If dr Is Nothing Then Return
        With dr
            .Item("sex") = IIf(rbtnMale.Checked, "男", "女")
            .Item("address") = txtAddress.Text
            .Item("age") = MyIIf(txtAge.Text, GetType(Integer), DBNull.Value)
            .Item("phone") = txtPhone.Text
            .Item("IC_code") = txtIDCard.Text
            .Item("assets_bill") = txtMaterial.Text
        End With
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim inx As Int32 = cmbxMan.FindStringExact(cmbxMan.Text)
        If inx >= 0 Then
            CopyValue(dsPerson.Tables(0).Rows(inx))
        Else
            Dim dr As DataRow = dsPerson.Tables(0).NewRow
            CopyValue(dr)
            With dr
                .Item("project_code") = ProjectCode
                .Item("name") = cmbxMan.Text
                .Item("status") = "申请"
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate.Date
            End With
            dsPerson.Tables(0).Rows.Add(dr)
            cmbxMan.Items.Add(cmbxMan.Text)
        End If
        Dim strResult As String = gWs.UpdateOppositeGuaranteeAssurer(dsPerson.GetChanges)
        If strResult = "1" Then
            IsChanged = False
            If sender Is Nothing Then Return
            'MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            GetDataSource()
        Else
            'MessageBox.Show("保存失败" & vbCr & strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        'MessageBox.Show("您将删除该条信息记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes
        If SWDialogBox.MessageBox.Show("?1004", """" & cmbxMan.Text & """") = DialogResult.Yes Then
            dsPerson.Tables(0).Select("name LIKE '" & cmbxMan.Text & "'")(0).Delete()
            Dim strResult As String = gWs.UpdateOppositeGuaranteeAssurer(dsPerson)
            If strResult = "1" Then
                SWDialogBox.MessageBox.Show("$DeleteSucceed")
                'MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dsPerson.AcceptChanges()
                cmbxMan.Items.RemoveAt(cmbxMan.FindStringExact(cmbxMan.Text))
                cmbxMan.Text = String.Empty
                cmbxMan_TextChanged(sender, e)
            Else
                SWDialogBox.MessageBox.Show("*999", "删除失败", strResult, "")
                'MessageBox.Show("删除失败" & vbCr & strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            btnDelete.Enabled = False : btnSave.Enabled = False
        End If
    End Sub

    Private IsChanged As Boolean = False
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub

    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If IsChanged Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003") 'MessageBox.Show("数据已修改，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If QueryResult = DialogResult.Yes Then
                btnSave_Click(Nothing, Nothing)
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frmPersonAssure_Closing
        Close()
        Return True
    End Function

    Private Sub txt_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtAddress.Enter, txtAge.Enter, txtIDCard.Enter, txtPhone.Enter
        Money.SetObjTag(sender)
    End Sub
    Private Sub txt_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtAddress.Leave, txtAge.Leave, txtIDCard.Leave, txtPhone.Leave
        IsChanged = Money.IsChanged(sender)
    End Sub
    Private Sub rbtn_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles rbtnFemale.Enter, rbtnMale.Enter
        With CType(sender, RadioButton)
            .Tag = .Checked
        End With
    End Sub
    Private Sub rbtn_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles rbtnFemale.Leave, rbtnMale.Leave
        With CType(sender, RadioButton)
            IsChanged = System.Object.Equals(.Tag, .Checked)
        End With
    End Sub

    Private Sub txtDigit_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtAge.KeyPress ', txtIDCard.KeyPress
        e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ChrW(8))
    End Sub

    Private Sub frmPersonAssure_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub
End Class
