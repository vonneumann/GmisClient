Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FBank
    Inherits FMasterDetailDataForm

#Region " Windows 窗体设计器生成的代码 "

	Public Sub New()
		MyBase.New()

		'该调用是 Windows 窗体设计器所必需的。
		InitializeComponent()
        Me.csAddress.TextBox.MaxLength = 30
        Me.cs_address.TextBox.MaxLength = 30
        Me.csContactPerson.TextBox.MaxLength = 10
        Me.cs_contact_person.TextBox.MaxLength = 10
        Me.csContactPhone.TextBox.MaxLength = 15
        Me.cs_contact_phone.TextBox.MaxLength = 15
        Me.csFax.TextBox.MaxLength = 15
        Me.cs_fax.TextBox.MaxLength = 15
        Me.csPrincipal.TextBox.MaxLength = 10
        Me.cs_principal.TextBox.MaxLength = 10
        Me.csPrincipalPhone.TextBox.MaxLength = 15
        Me.cs_principal_phone.TextBox.MaxLength = 15
        Me.csCreatePerson.TextBox.MaxLength = 10
        Me.cs_create_person.TextBox.MaxLength = 10
        Me.csDetailBankBrachNo.TextBox.MaxLength = 2
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
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csDetailBankNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csDetailBankBrachNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csBankNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csBankName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csAddress As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csContactPerson As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csContactPhone As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csFax As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPrincipal As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPrincipalPhone As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCreatePerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCreateDate As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents tsBank As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents cs_branch_bank_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cs_address As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cs_contact_person As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cs_contact_phone As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cs_fax As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cs_principal As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cs_principal_phone As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cs_create_person As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cs_create_date As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FBank))
        Me.tsBank = New System.Windows.Forms.DataGridTableStyle()
        Me.csBankNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csBankName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAddress = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csContactPerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csContactPhone = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csFax = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPrincipal = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPrincipalPhone = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCreatePerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCreateDate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.csDetailBankNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csDetailBankBrachNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cs_branch_bank_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cs_address = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cs_contact_person = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cs_contact_phone = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cs_fax = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cs_principal = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cs_principal_phone = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cs_create_person = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cs_create_date = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdMaster
        '
        Me.grdMaster.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsBank})
        '
        'tsBank
        '
        Me.tsBank.DataGrid = Me.grdMaster
        Me.tsBank.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csBankNo, Me.csBankName, Me.csAddress, Me.csContactPerson, Me.csContactPhone, Me.csFax, Me.csPrincipal, Me.csPrincipalPhone, Me.csCreatePerson, Me.csCreateDate})
        Me.tsBank.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsBank.MappingName = "bank"
        '
        'csBankNo
        '
        Me.csBankNo.Format = ""
        Me.csBankNo.FormatInfo = Nothing
        Me.csBankNo.HeaderText = "银行编号"
        Me.csBankNo.MappingName = "bank_code"
        Me.csBankNo.NullText = ""
        Me.csBankNo.Width = 60
        '
        'csBankName
        '
        Me.csBankName.Format = ""
        Me.csBankName.FormatInfo = Nothing
        Me.csBankName.HeaderText = "银行名称"
        Me.csBankName.MappingName = "bank_name"
        Me.csBankName.NullText = ""
        Me.csBankName.Width = 150
        '
        'csAddress
        '
        Me.csAddress.Format = ""
        Me.csAddress.FormatInfo = Nothing
        Me.csAddress.HeaderText = "地  址"
        Me.csAddress.MappingName = "address"
        Me.csAddress.NullText = ""
        Me.csAddress.Width = 200
        '
        'csContactPerson
        '
        Me.csContactPerson.Format = ""
        Me.csContactPerson.FormatInfo = Nothing
        Me.csContactPerson.HeaderText = "联系人"
        Me.csContactPerson.MappingName = "contact_person"
        Me.csContactPerson.NullText = ""
        Me.csContactPerson.Width = 60
        '
        'csContactPhone
        '
        Me.csContactPhone.Format = ""
        Me.csContactPhone.FormatInfo = Nothing
        Me.csContactPhone.HeaderText = "电话号码"
        Me.csContactPhone.MappingName = "contact_phone"
        Me.csContactPhone.NullText = ""
        Me.csContactPhone.Width = 90
        '
        'csFax
        '
        Me.csFax.Format = ""
        Me.csFax.FormatInfo = Nothing
        Me.csFax.HeaderText = "传真号码"
        Me.csFax.MappingName = "fax"
        Me.csFax.NullText = ""
        Me.csFax.Width = 90
        '
        'csPrincipal
        '
        Me.csPrincipal.Format = ""
        Me.csPrincipal.FormatInfo = Nothing
        Me.csPrincipal.HeaderText = "负责人"
        Me.csPrincipal.MappingName = "principal"
        Me.csPrincipal.NullText = ""
        Me.csPrincipal.Width = 60
        '
        'csPrincipalPhone
        '
        Me.csPrincipalPhone.Format = ""
        Me.csPrincipalPhone.FormatInfo = Nothing
        Me.csPrincipalPhone.HeaderText = "电话号码"
        Me.csPrincipalPhone.MappingName = "principal_phone"
        Me.csPrincipalPhone.NullText = ""
        Me.csPrincipalPhone.Width = 90
        '
        'csCreatePerson
        '
        Me.csCreatePerson.Format = ""
        Me.csCreatePerson.FormatInfo = Nothing
        Me.csCreatePerson.HeaderText = "创建人"
        Me.csCreatePerson.MappingName = "create_person"
        Me.csCreatePerson.NullText = ""
        Me.csCreatePerson.ReadOnly = True
        Me.csCreatePerson.Width = 60
        '
        'csCreateDate
        '
        Me.csCreateDate.Format = "D"
        Me.csCreateDate.FormatInfo = Nothing
        Me.csCreateDate.HeaderText = "创建日期"
        Me.csCreateDate.MappingName = "create_date"
        Me.csCreateDate.NullText = ""
        Me.csCreateDate.ReadOnly = True
        Me.csCreateDate.Width = 90
        '
        'grdDetail
        '
        Me.grdDetail.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.grdDetail
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csDetailBankNo, Me.csDetailBankBrachNo, Me.cs_branch_bank_name, Me.cs_address, Me.cs_contact_person, Me.cs_contact_phone, Me.cs_fax, Me.cs_principal, Me.cs_principal_phone, Me.cs_create_person, Me.cs_create_date})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "bank_branch"
        '
        'csDetailBankNo
        '
        Me.csDetailBankNo.Format = ""
        Me.csDetailBankNo.FormatInfo = Nothing
        Me.csDetailBankNo.HeaderText = "银行编号"
        Me.csDetailBankNo.MappingName = "bank_code"
        Me.csDetailBankNo.NullText = ""
        Me.csDetailBankNo.ReadOnly = True
        Me.csDetailBankNo.Width = 60
        '
        'csDetailBankBrachNo
        '
        Me.csDetailBankBrachNo.Format = ""
        Me.csDetailBankBrachNo.FormatInfo = Nothing
        Me.csDetailBankBrachNo.HeaderText = "支行编号"
        Me.csDetailBankBrachNo.MappingName = "branch_bank_code"
        Me.csDetailBankBrachNo.NullText = ""
        Me.csDetailBankBrachNo.Width = 60
        '
        'cs_branch_bank_name
        '
        Me.cs_branch_bank_name.Format = ""
        Me.cs_branch_bank_name.FormatInfo = Nothing
        Me.cs_branch_bank_name.HeaderText = "支行名称"
        Me.cs_branch_bank_name.MappingName = "branch_bank_name"
        Me.cs_branch_bank_name.NullText = ""
        Me.cs_branch_bank_name.Width = 150
        '
        'cs_address
        '
        Me.cs_address.Format = ""
        Me.cs_address.FormatInfo = Nothing
        Me.cs_address.HeaderText = "支行地址"
        Me.cs_address.MappingName = "address"
        Me.cs_address.NullText = ""
        Me.cs_address.Width = 200
        '
        'cs_contact_person
        '
        Me.cs_contact_person.Format = ""
        Me.cs_contact_person.FormatInfo = Nothing
        Me.cs_contact_person.HeaderText = "联系人"
        Me.cs_contact_person.MappingName = "contact_person"
        Me.cs_contact_person.NullText = ""
        Me.cs_contact_person.Width = 60
        '
        'cs_contact_phone
        '
        Me.cs_contact_phone.Format = ""
        Me.cs_contact_phone.FormatInfo = Nothing
        Me.cs_contact_phone.HeaderText = "电话号码"
        Me.cs_contact_phone.MappingName = "contact_phone"
        Me.cs_contact_phone.NullText = ""
        Me.cs_contact_phone.Width = 90
        '
        'cs_fax
        '
        Me.cs_fax.Format = ""
        Me.cs_fax.FormatInfo = Nothing
        Me.cs_fax.HeaderText = "传真号码"
        Me.cs_fax.MappingName = "fax"
        Me.cs_fax.NullText = ""
        Me.cs_fax.Width = 90
        '
        'cs_principal
        '
        Me.cs_principal.Format = ""
        Me.cs_principal.FormatInfo = Nothing
        Me.cs_principal.HeaderText = "负责人"
        Me.cs_principal.MappingName = "principal"
        Me.cs_principal.NullText = ""
        Me.cs_principal.Width = 60
        '
        'cs_principal_phone
        '
        Me.cs_principal_phone.Format = ""
        Me.cs_principal_phone.FormatInfo = Nothing
        Me.cs_principal_phone.HeaderText = "电话号码"
        Me.cs_principal_phone.MappingName = "principal_phone"
        Me.cs_principal_phone.NullText = ""
        Me.cs_principal_phone.Width = 90
        '
        'cs_create_person
        '
        Me.cs_create_person.Format = ""
        Me.cs_create_person.FormatInfo = Nothing
        Me.cs_create_person.HeaderText = "创建人"
        Me.cs_create_person.MappingName = "create_person"
        Me.cs_create_person.NullText = ""
        Me.cs_create_person.ReadOnly = True
        Me.cs_create_person.Width = 60
        '
        'cs_create_date
        '
        Me.cs_create_date.Format = "D"
        Me.cs_create_date.FormatInfo = Nothing
        Me.cs_create_date.HeaderText = "创建日期"
        Me.cs_create_date.MappingName = "create_date"
        Me.cs_create_date.NullText = ""
        Me.cs_create_date.ReadOnly = True
        Me.cs_create_date.Width = 90
        '
        'FBank
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.DockPadding.Bottom = 40
        Me.DockPadding.Left = 8
        Me.DockPadding.Right = 8
        Me.DockPadding.Top = 8
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FBank"
        Me.Text = "合作银行设置"
        CType(Me.grdMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides Function RefreshData() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsBank As DataSet = gWs.GetBankInfo("%", "%")

            grdMaster.SetDataBinding(dsBank, "bank")
            grdDetail.SetDataBinding(dsBank, "bank_branch")

            Dim masterManager As CurrencyManager = CType(Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember), CurrencyManager)
            AddHandler masterManager.PositionChanged, AddressOf MasterTable_PositionChanged

            AddHandler dsBank.Tables("bank").RowDeleted, AddressOf MasterTable_RowDeleted
            AddHandler dsBank.Tables("bank").RowChanged, AddressOf MasterTable_RowChanged
            AddHandler dsBank.Tables("bank_branch").RowChanged, AddressOf DetailTable_RowChanged

            MyBase.RefreshData()

            '强制刷新从表数据
            MasterTable_PositionChanged(masterManager, EventArgs.Empty)
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Protected Overrides Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("bank_code IS NULL OR bank_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "银行编号")
            Return False
        End If
        If data.Select("bank_name IS NULL OR bank_name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "银行名称")
            Return False
        End If

        Dim i, j As Int32
        Dim rows As DataRow() = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("bank_code") = rows(j)("bank_code") Then
                    SWDialogBox.MessageBox.Show("$1003", "银行编号")
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Protected Overrides Function ValidateDetail(ByVal data As DataTable) As Boolean
        If data.Select("bank_code IS NULL OR bank_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "银行编号")
            Return False
        End If
        If data.Select("branch_bank_code IS NULL OR branch_bank_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "分行编号")
            Return False
        End If
        If data.Select("branch_bank_name IS NULL OR branch_bank_name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "分行名称")
            Return False
        End If

        Dim i, j As Int32
        Dim rows As DataRow() = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("bank_code") = rows(j)("bank_code") AndAlso _
                   rows(i)("branch_bank_code") = rows(j)("branch_bank_code") Then
                    SWDialogBox.MessageBox.Show("$1003", "分行编号")
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Public Overrides Function UpdateData() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            If Not MyBase.UpdateData() Then
                Return False
            End If

            Dim dsBank As DataSet = CType(grdMaster.DataSource, DataSet)

            Dim result As String

            result = gWs.UpdateBankAndBranch(dsBank.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsBank.AcceptChanges()

                '调用基类的刷新函数以重新刷新当前操作状态
                MyBase.RefreshData()

                Return True
            Else
                '显示服务器的返回错误信息
                SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
            End If
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return False
    End Function

    Private Sub FBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RefreshData()
    End Sub

    Private Sub MasterTable_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If grdMaster.DataSource Is Nothing OrElse grdDetail.DataSource Is Nothing Then
            Return
        End If

        Try
            Dim masterManager As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
            Dim dv As DataView = CType(CType(Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember), CurrencyManager).List, DataView)

            If masterManager.Position < 0 Then
                dv.RowFilter = "bank_code = NULL"
                dv.Table.Columns("bank_code").DefaultValue = DBNull.Value
            Else
                Dim rv As DataRowView = CType(masterManager.Current, DataRowView)

                dv.RowFilter = "bank_code = '" + rv("bank_code").ToString() + "'"
                dv.Table.Columns("bank_code").DefaultValue = rv("bank_code")
            End If
        Catch ex As Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub MasterTable_RowDeleted(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        'If Not grdDetail.DataSource Is Nothing Then
        '    Dim rows As DataRow() = CType(grdDetail.DataSource, DataSet).Tables("bank_branch").Select("bank_code = '" + e.Row("bank_code").ToString() + "'")

        '    Dim i As Int32

        '    For i = 0 To rows.Length - 1
        '        rows(i).Delete()
        '    Next
        'End If

        MasterTable_PositionChanged(Nothing, EventArgs.Empty)
    End Sub

    Private Sub MasterTable_RowChanged(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        If e.Action = DataRowAction.Add Then
            e.Row.Item("create_person") = UserName
            e.Row.Item("create_date") = DateTime.Now

            MasterTable_PositionChanged(Nothing, EventArgs.Empty)
        End If
    End Sub

    '注意：在该事件内不要再重新给“bank_code”赋值了，因为当主表记录指针变动事件会先于该事件，所以，在此获取的主表记录未必是对应的原来的主表记录。
    '当前从表记录的“bank_code”字段的值为主表事件内定义的默认值。
    Private Sub DetailTable_RowChanged(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim rv As DataRowView = CType(Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember).Current, DataRowView)

        If e.Action = DataRowAction.Add Then
            'RemoveHandler CType(sender, DataTable).RowChanged, AddressOf DetailTable_RowChanged

            e.Row.Item("create_person") = UserName
            e.Row.Item("create_date") = gWs.GetSysTime()

            'AddHandler CType(sender, DataTable).RowChanged, AddressOf DetailTable_RowChanged
        End If
    End Sub

    Protected Overrides Function DeleteMasterConfirm() As DialogResult
        Dim cm As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        If cm.Count <= 0 Then
            Return DialogResult.None
        End If

        Return SWDialogBox.MessageBox.Show("?1004", "［" + CType(cm.Current, DataRowView)("bank_name") + "］")
    End Function

    Protected Overrides Function DeleteDetailConfirm() As DialogResult
        Dim cm As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)
        If cm.Count <= 0 Then
            Return DialogResult.None
        End If

        Return SWDialogBox.MessageBox.Show("?1004", "［" + CType(cm.Current, DataRowView)("branch_bank_name") + "］")
    End Function
End Class
