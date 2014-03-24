Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FCooperateOrganization
    Inherits FBaseData

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        Me.csNo.TextBox.MaxLength = 2
        Me.csName.TextBox.MaxLength = 20
        Me.csAddress.TextBox.MaxLength = 30
        Me.csContactPerson.TextBox.MaxLength = 10
        Me.csContactPhone.TextBox.MaxLength = 15
        Me.csFax.TextBox.MaxLength = 15
        Me.csPrincipal.TextBox.MaxLength = 10
        Me.csPrincipalPhone.TextBox.MaxLength = 15
        Me.csManager.TextBox.MaxLength = 10
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
    Friend WithEvents csNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csAddress As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csContactPerson As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csContactPhone As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csFax As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csPrincipal As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csPrincipalPhone As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csManager As DataGridComboBoxColumn
    Friend WithEvents csCreatePerson As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tsOrganization As System.Windows.Forms.DataGridTableStyle
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FCooperateOrganization))
        Me.tsOrganization = New System.Windows.Forms.DataGridTableStyle()
        Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAddress = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csContactPerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csContactPhone = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csFax = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPrincipal = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPrincipalPhone = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csManager = New DataGridComboBoxColumn()
        Me.csCreatePerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCreateDate = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsOrganization})
        Me.grdTable.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'tsOrganization
        '
        Me.tsOrganization.DataGrid = Me.grdTable
        Me.tsOrganization.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName, Me.csAddress, Me.csContactPerson, Me.csContactPhone, Me.csFax, Me.csPrincipal, Me.csPrincipalPhone, Me.csManager, Me.csCreatePerson, Me.csCreateDate})
        Me.tsOrganization.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsOrganization.MappingName = "TCooperateOrganization"
        '
        'csNo
        '
        Me.csNo.Format = ""
        Me.csNo.FormatInfo = Nothing
        Me.csNo.HeaderText = "区局编号"
        Me.csNo.MappingName = "cooperate_organization_code"
        Me.csNo.NullText = ""
        Me.csNo.Width = 60
        '
        'csName
        '
        Me.csName.Format = ""
        Me.csName.FormatInfo = Nothing
        Me.csName.HeaderText = "区局名称"
        Me.csName.MappingName = "cooperate_organization"
        Me.csName.NullText = ""
        Me.csName.Width = 150
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
        'csManager
        '
        Me.csManager.Format = ""
        Me.csManager.FormatInfo = Nothing
        Me.csManager.HeaderText = "专 管 员"
        Me.csManager.MappingName = "manager"
        Me.csManager.NullText = ""
        Me.csManager.Width = 80
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
        'FCooperateOrganization
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Name = "FCooperateOrganization"
        Me.Text = "合作区局设置"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetCooperateOrganization("%")
			grdTable.SetDataBinding(dsResult, "TCooperateOrganization")

			AddHandler dsResult.Tables("TCooperateOrganization").RowChanged, AddressOf MasterTable_RowChanged
		Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try
    End Sub

    Private Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("cooperate_organization IS NULL OR cooperate_organization=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "区局名称")
            Return False
        End If

        If data.Select("cooperate_organization_code IS NULL OR cooperate_organization_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "区局编号")
            Return False
        End If

        If data.Select("manager IS NULL OR manager=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "专管员")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("cooperate_organization") = rows(j)("cooperate_organization") Then
                    SWDialogBox.MessageBox.Show("$1003", "区局名称")
                    Return False
                End If

                If rows(i)("cooperate_organization_code") = rows(j)("cooperate_organization_code") Then
                    SWDialogBox.MessageBox.Show("$1003", "区局编号")
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)

            If (Not dsCommit.HasChanges()) OrElse (Not ValidateMaster(dsCommit.Tables(0))) Then
                Return False
            End If

            Dim result As String = gWs.UpdateCooperateOrganization(dsCommit.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsCommit.AcceptChanges()

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

    Private Sub FBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsStaff As DataSet = gWs.GetStaff("%")
        'grdTable.TableStyles.Add(Me.tsOrganization)

        csManager.ColumnComboBox.DataSource = dsStaff.Tables("TStaff").DefaultView
        csManager.ColumnComboBox.DisplayMember = "staff_name"
        csManager.ColumnComboBox.ValueMember = "staff_name"
    End Sub

    Private Sub MasterTable_RowChanged(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        If e.Action = DataRowAction.Add Then
            e.Row.Item("create_person") = UserName
            e.Row.Item("create_date") = DateTime.Now
        End If
    End Sub
End Class
