Public Class frmEstateContract
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    Private strProjectCode, strContractName As String
    Private dsProjectContractEstate As DataSet

    Public Sub New(ByVal ProjectCode As String, ByVal ContractName As String, ByVal ProjectContractEstateList As DataSet)
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

        strProjectCode = ProjectCode
        strContractName = ContractName
        dsProjectContractEstate = ProjectContractEstateList
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
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEstateContract))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 382)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(3, 17)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(654, 362)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "project_contract_estate_element"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "房地产权利人"
        Me.DataGridTextBoxColumn1.MappingName = "obligee"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 150
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "房地产证号"
        Me.DataGridTextBoxColumn2.MappingName = "credentials"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "房地产名称、栋号、房号"
        Me.DataGridTextBoxColumn3.MappingName = "detail"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 400
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(500, 396)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(588, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.ImageIndex = 12
        Me.btnClear.ImageList = Me.ImageListBasic
        Me.btnClear.Location = New System.Drawing.Point(413, 396)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 24)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "清 空(&C)"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmEstateContract
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(672, 430)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEstateContract"
        Me.Text = "房产清单"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsGuarantee, dsGuaranteeDetail As DataSet

    Private Sub frmEstateContract_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSql As String
        strSql = "{project_code='" & strProjectCode & "' and contract_name='" & Trim(strContractName) & "'}"
        dsProjectContractEstate = gWs.GetProjectContractEstateElementInfo(strSql)

        '填充房产清单
        If dsProjectContractEstate.Tables(0).Rows.Count = 0 Then

            '获取评审通过的房产
            strSql = "select project_code,serial_num from opposite_guarantee where project_code='" & strProjectCode & "' and guaranty_type in ('21','2M') and status='评审通过'"
            dsGuarantee = gWs.GetCommonQueryInfo(strSql)

            If dsGuarantee.Tables(0).Rows.Count <> 0 Then


                '获取评审通过的房产的明细信息
                strSql = "SELECT dbo.opposite_guarantee.project_code, dbo.opposite_guarantee.serial_num, " & _
                         " dbo.opposite_guarantee_detail.item_code,dbo.opposite_guarantee_detail.item_value  " & _
                         " FROM dbo.opposite_guarantee INNER JOIN  " & _
                         " dbo.opposite_guarantee_detail ON  " & _
                         " dbo.opposite_guarantee.project_code = dbo.opposite_guarantee_detail.project_code And " & _
                         " dbo.opposite_guarantee.serial_num = dbo.opposite_guarantee_detail.serial_num  " & _
                         " WHERE  opposite_guarantee.project_code='" & strProjectCode & "' and (dbo.opposite_guarantee.status = N'评审通过') AND   " & _
                         " (dbo.opposite_guarantee.guaranty_type in  ('21','2M')) AND  " & _
                         " (dbo.opposite_guarantee_detail.item_type in  ('21','2M')) AND  " & _
                         " (dbo.opposite_guarantee_detail.item_code IN ('001', '002', '003'))"
                dsGuaranteeDetail = gWs.GetCommonQueryInfo(strSql)


                Dim i, j As Integer
                Dim dr, drTemp As DataRow
                Dim strSerialNum As String
                For i = 0 To dsGuarantee.Tables(0).Rows.Count - 1
                    j = j + 1
                    strSerialNum = dsGuarantee.Tables(0).Rows(i).Item("serial_num")
                    dr = dsProjectContractEstate.Tables(0).NewRow
                    With dr
                        dr.Item("project_code") = strProjectCode
                        dr.Item("num") = j
                        dr.Item("contract_name") = Trim(strContractName)
                        For Each drTemp In dsGuaranteeDetail.Tables(0).Select("serial_num='" & strSerialNum & "'")

                            Select Case drTemp.Item("item_code")
                                Case "001"
                                    dr.Item("credentials") = drTemp.Item("item_value")
                                Case "002"
                                    dr.Item("obligee") = drTemp.Item("item_value")
                                Case "003"
                                    dr.Item("detail") = drTemp.Item("item_value")
                            End Select
                        Next
                    End With
                    dsProjectContractEstate.Tables(0).Rows.Add(dr)
                Next
            End If
        End If

        DataGrid1.DataSource = dsProjectContractEstate.Tables(0)
        setDgAttribute(DataGrid1, Me)

        If btnSave.Visible = False Then
            setDgDeleteAttribute(DataGrid1, Me)
        End If


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strResult As String = gWs.UpdateProjectContractEstateElement(dsProjectContractEstate)
        If (strResult = "1") Then
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            dsProjectContractEstate.AcceptChanges()
        Else
            SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim i As Integer
        For i = 0 To dsProjectContractEstate.Tables(0).Rows.Count - 1
            dsProjectContractEstate.Tables(0).Rows(i).Delete()
        Next
        DataGrid1.DataSource = dsProjectContractEstate.Tables(0)
        setDgAttribute(DataGrid1, Me)
        'setDgDeleteAttribute(DataGrid1, Me)
    End Sub
End Class
