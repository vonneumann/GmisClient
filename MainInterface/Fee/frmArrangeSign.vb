

Public Class frmArrangeSign
    Inherits frmBasic
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsPro Is Nothing Then
            dsPro.Dispose()
        End If
        If Not dsSig Is Nothing Then
            dsSig.Dispose()
        End If
        If Not dsTemp Is Nothing Then
            dsTemp.Dispose()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgList As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnArrange As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgProject As System.Windows.Forms.DataGrid
    Friend WithEvents mcDate As SWCalendar.MyCalendar
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelProject As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrangeSign))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgList = New System.Windows.Forms.DataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnArrange = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.mcDate = New SWCalendar.MyCalendar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgProject = New System.Windows.Forms.DataGrid()
        Me.btnCancelProject = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnExit.Location = New System.Drawing.Point(578, 512)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgList})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 146)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "签约安排列表"
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
        Me.dgList.Size = New System.Drawing.Size(666, 126)
        Me.dgList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(328, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "地点"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(328, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "备注"
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Bitmap)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(323, 512)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 23)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "修 改(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(238, 512)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(493, 512)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Tag = "nothing"
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Enabled = False
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(408, 512)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnArrange
        '
        Me.btnArrange.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnArrange.Image = CType(resources.GetObject("btnArrange.Image"), System.Drawing.Bitmap)
        Me.btnArrange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArrange.ImageIndex = 1
        Me.btnArrange.ImageList = Me.ImageListBasic
        Me.btnArrange.Location = New System.Drawing.Point(137, 512)
        Me.btnArrange.Name = "btnArrange"
        Me.btnArrange.Size = New System.Drawing.Size(93, 23)
        Me.btnArrange.TabIndex = 4
        Me.btnArrange.Text = "项目安排(&A)"
        Me.btnArrange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAddress, Me.txtRemark, Me.lblMessage, Me.mcDate, Me.Label2, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 184)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(360, 56)
        Me.txtAddress.MaxLength = 30
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(304, 21)
        Me.txtAddress.TabIndex = 2
        Me.txtAddress.Text = ""
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtRemark.Enabled = False
        Me.txtRemark.Location = New System.Drawing.Point(360, 104)
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(304, 64)
        Me.txtRemark.TabIndex = 39
        Me.txtRemark.Text = ""
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
        Me.lblMessage.BackColor = System.Drawing.Color.Orange
        Me.lblMessage.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(328, 16)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(336, 24)
        Me.lblMessage.TabIndex = 38
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mcDate
        '
        Me.mcDate.Location = New System.Drawing.Point(8, 14)
        Me.mcDate.Name = "mcDate"
        Me.mcDate.Size = New System.Drawing.Size(317, 168)
        Me.mcDate.TabIndex = 37
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgProject})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(672, 160)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "项目列表"
        '
        'dgProject
        '
        Me.dgProject.CaptionVisible = False
        Me.dgProject.DataMember = ""
        Me.dgProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProject.Location = New System.Drawing.Point(3, 17)
        Me.dgProject.Name = "dgProject"
        Me.dgProject.ReadOnly = True
        Me.dgProject.Size = New System.Drawing.Size(666, 140)
        Me.dgProject.TabIndex = 0
        '
        'btnCancelProject
        '
        Me.btnCancelProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelProject.Enabled = False
        Me.btnCancelProject.Image = CType(resources.GetObject("btnCancelProject.Image"), System.Drawing.Bitmap)
        Me.btnCancelProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelProject.ImageIndex = 25
        Me.btnCancelProject.ImageList = Me.ImageListBasic
        Me.btnCancelProject.Location = New System.Drawing.Point(36, 512)
        Me.btnCancelProject.Name = "btnCancelProject"
        Me.btnCancelProject.Size = New System.Drawing.Size(93, 23)
        Me.btnCancelProject.TabIndex = 39
        Me.btnCancelProject.Text = "撤销项目(&R)"
        Me.btnCancelProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmArrangeSign
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(690, 543)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancelProject, Me.GroupBox3, Me.GroupBox1, Me.btnArrange, Me.btnNew, Me.btnSave, Me.btnDelete, Me.btnModify, Me.GroupBox2, Me.btnExit})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArrangeSign"
        Me.Text = "安排签约"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsSig As DataSet
    Private bmSig As BindingManagerBase
    Private SystemDate As DateTime
    Private dsPro As DataSet
    Private bmProject As CurrencyManager
    Private dsTemp As DataSet
    Private bmTemp As CurrencyManager
    Private TaskID As String
    Public IsOwnedFormCommit As Boolean = False  '子窗体是否已提交
    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            TaskID = MyBase.getTaskID
            SystemDate = gWs.GetSysTime
            
            dsSig = gWs.GetSignaturePlanInfo("{signature_plan_date>='" & SystemDate.Date & "'}") 'SystemDate.Date
            bmSig = BindingContext(dsSig, "signature_plan")
            If bmSig.Count > 0 Then
                Dim i As Integer
                For i = 0 To bmSig.Count - 1
                    mcDate.AddColorDate(dsSig.Tables(0).Rows(i)("signature_plan_date"))
                Next
                mcDate.UpdateColorDates()
            End If
            mcDate.SetToday(SystemDate.Date)
            ReturnSigEachDay(mcDate.SelectedDate)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub mcDate_DateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles mcDate.DateChanged
        Try
            Me.Cursor = Cursors.WaitCursor
            ReturnSigEachDay(mcDate.SelectedDate)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub ReturnSigEachDay(ByVal EachDay As Date)
        Dim str As String = EachDay.ToString("yyyy-MM-dd")
        If bmTemp Is Nothing Then
            dsTemp = New DataSet()
            dsTemp = dsSig.Clone
            dsTemp.Merge(dsSig.Tables(0).Select("signature_plan_date=#" & str & "#"))
            bmTemp = BindingContext(dsTemp, "signature_plan")
            dgList.DataMember = "signature_plan"
            dgList.DataSource = dsTemp
            AddTableStyle()
            bmTemp_PositionChanged(Nothing, Nothing)
            AddHandler bmTemp.PositionChanged, AddressOf bmTemp_PositionChanged
            RefreshMessage()
            Return
        ElseIf bmTemp.Count > 0 Then
            Dim i As Integer
            Dim k As Integer = bmTemp.Count
            For i = k - 1 To 0 Step -1
                dsTemp.Tables(0).Rows.RemoveAt(i)
            Next
        End If
        dsTemp.Merge(dsSig.Tables(0).Select("signature_plan_date=#" & str & "#"))
        'Dim odr As DataRow
        'Dim drs() As DataRow = dsSig.Tables(0).Select("signature_plan_date=#" & str & "#")
        'For Each odr In drs
        '    dsTemp.Tables(0).ImportRow(odr)
        'Next
        'If dsTemp.HasChanges Then
        '    dsTemp.AcceptChanges()
        'End If
        If bmTemp.Count = 0 Then
            If Not bmProject Is Nothing Then
                CType(bmProject.List, DataView).RowFilter = "SigCode = -1"
            End If
            'Else
            '    CType(bmProject.List, DataView).RowFilter = "SigCode =" & CType(bmTemp.Current, DataRowView)("signature_plan_code").ToString
            'ClearProject()
        End If

        If btnSave.Tag.ToString = "nothing" Then
            RefreshMessage()
        End If
    End Sub

    Private Sub RefreshMessage()
        btnArrange.Enabled = bmTemp.Count > 0
        btnModify.Enabled = btnArrange.Enabled
        btnDelete.Enabled = btnModify.Enabled
        btnNew.Enabled = True
        lblMessage.Text = "选择日期：" & mcDate.SelectedDate.ToString("yyyy-MM-dd") & IIf(btnArrange.Enabled, "，有签约计划", "，没签约计划")
        If Not bmProject Is Nothing Then
            btnCancelProject.Enabled = bmProject.Count > 0
        End If
    End Sub

    Private Sub ClearProject()
        If Not bmProject Is Nothing Then
            Dim i, k As Integer
            k = bmProject.Count
            For i = k - 1 To 0 Step -1
                dsPro.Tables(0).Rows.RemoveAt(i)
            Next
        End If
    End Sub

    Private strSigCode As String = String.Empty

    Public Sub bmTemp_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        'ClearProject()
        'If Not bmProject Is Nothing Then
        '    CType(bmProject.List, DataView).RowFilter = "SigCode = -1"
        'End If

        If bmTemp.Count = 0 Then Return

        With CType(bmTemp.Current, DataRowView)
            txtAddress.Text = IIf(IsDBNull(.Item("place")), "", CStr(.Item("place")))
            txtRemark.Text = IIf(IsDBNull(.Item("remark")), "", CStr(.Item("remark")))
        End With
        If CStr(CType(bmTemp.Current, DataRowView)("status")) <> "已提交" Then
            If Not bmProject Is Nothing Then
                CType(bmProject.List, DataView).RowFilter = "SigCode = -1"
            End If
            If btnSave.Tag.ToString = "nothing" Then
                RefreshMessage()
            End If
            Return
        End If

        Dim SigCode As Integer = CInt(CType(bmTemp.Current, DataRowView)("signature_plan_code"))
        If strSigCode.IndexOf(SigCode.ToString) < 0 Then
            strSigCode += IIf(strSigCode = String.Empty, SigCode.ToString, "," & SigCode.ToString)
            Dim eachDr, newDr As DataRow
            Dim eachCol As DataColumn
            Dim dsT As DataSet
            If bmProject Is Nothing Then
                dsT = gWs.GetNeedSignatureProjectInfo("{project_signature.signature_plan_code=" & SigCode & "}")
                dsPro = New DataSet()
                dsPro = dsT.Clone
                dsPro.Tables(0).Columns.Add("SigCode", GetType(Integer))
                For Each eachDr In dsT.Tables(0).Rows
                    newDr = dsPro.Tables(0).NewRow
                    For Each eachCol In dsT.Tables(0).Columns
                        newDr(eachCol.ColumnName) = eachDr(eachCol.ColumnName)
                    Next
                    newDr("SigCode") = SigCode
                    dsPro.Tables(0).Rows.Add(newDr)
                Next
                bmProject = BindingContext(dsPro, "Table")
                dgProject.DataMember = "Table"
                dgProject.DataSource = dsPro
                AddTableStyleForProject()
                dsT.Dispose()
                Return
            End If
            dsT = gWs.GetNeedSignatureProjectInfo("{project_signature.signature_plan_code=" & SigCode & "}")
            For Each eachDr In dsT.Tables(0).Rows
                newDr = dsPro.Tables(0).NewRow
                For Each eachCol In dsT.Tables(0).Columns
                    newDr(eachCol.ColumnName) = eachDr(eachCol.ColumnName)
                Next
                newDr("SigCode") = SigCode
                dsPro.Tables(0).Rows.Add(newDr)
            Next
            dsT.Dispose()
        End If
        CType(bmProject.List, DataView).RowFilter = "SigCode =" & SigCode.ToString



        'Dim dr As DataRow
        'Dim drs As DataRowCollection = gWs.GetNeedSignatureProjectInfo("{project_signature.signature_plan_code=" & SigCode & "}").Tables(0).Rows
        'For Each dr In drs
        '    dsPro.Tables(0).ImportRow(dr)
        'Next
        'dsPro.AcceptChanges()
        If btnSave.Tag.ToString = "nothing" Then
            RefreshMessage()
        End If
    End Sub

    'Public Sub bmTemp_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    ClearProject()
    '    If bmTemp.Count = 0 Then Return

    '    With CType(bmTemp.Current, DataRowView)
    '        txtAddress.Text = IIf(IsDBNull(.Item("place")), "", CStr(.Item("place")))
    '        txtRemark.Text = IIf(IsDBNull(.Item("remark")), "", CStr(.Item("remark")))
    '    End With
    '    If CStr(CType(bmTemp.Current, DataRowView)("status")) <> "已提交" Then
    '        If btnSave.Tag.ToString = "nothing" Then
    '            RefreshMessage()
    '        End If
    '        Return
    '    End If

    '    Dim SigCode As Integer = CInt(CType(bmTemp.Current, DataRowView)("signature_plan_code"))
    '    If bmProject Is Nothing Then
    '        dsPro = gWs.GetNeedSignatureProjectInfo("{project_signature.signature_plan_code=" & SigCode & "}")
    '        bmProject = BindingContext(dsPro, "Table")
    '        dgProject.DataMember = "Table"
    '        dgProject.DataSource = dsPro
    '        AddTableStyleForProject()
    '        Return
    '    End If

    '    Dim dr As DataRow
    '    Dim drs As DataRowCollection = gWs.GetNeedSignatureProjectInfo("{project_signature.signature_plan_code=" & SigCode & "}").Tables(0).Rows
    '    For Each dr In drs
    '        dsPro.Tables(0).ImportRow(dr)
    '    Next
    '    dsPro.AcceptChanges()
    '    If btnSave.Tag.ToString = "nothing" Then
    '        RefreshMessage()
    '    End If
    'End Sub

    Private Sub AddTableStyleForProject()
        dgProject.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        dgts.AllowSorting = False
        'dgts.RowHeadersVisible = False
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()      'index 1
        col1.MappingName = "ProjectCode"
        col1.HeaderText = "项目编码"
        col1.Width = 65
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 3 
        col2.MappingName = "EnterpriseName"
        col2.HeaderText = "企业名称"
        col2.Alignment = HorizontalAlignment.Left
        col2.NullText = String.Empty
        col2.Width = 130
        dgts.GridColumnStyles.Add(col2)
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col9.MappingName = "ServiceType"
        col9.HeaderText = "业务品种"
        col9.Alignment = HorizontalAlignment.Left
        col9.Width = 120
        col9.NullText = String.Empty
        dgts.GridColumnStyles.Add(col9)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 5
        col3.MappingName = "ManagerA"
        col3.HeaderText = "项目经理A"
        col3.Width = 75
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        col7.MappingName = "ManagerB"
        col7.HeaderText = "项目经理B"
        col7.Width = 75
        col7.NullText = String.Empty
        col7.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col7)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "LawManager"                                      'index 0
        col5.HeaderText = "法务经理"
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 75
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 4  为删除dsConferenceTrial而设计
        col6.MappingName = "BankName"
        col6.HeaderText = "贷款银行"
        col6.Width = 110
        col6.NullText = String.Empty
        col6.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col6)
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col10.MappingName = "GuarantySum"
        col10.HeaderText = "担保金额(万元)"
        col10.Alignment = HorizontalAlignment.Left
        col10.Width = 100
        col10.Format = "n"
        col10.NullText = String.Empty
        dgts.GridColumnStyles.Add(col10)
        dgProject.TableStyles.Add(dgts)
    End Sub

    Private Sub AddTableStyle()
        dgList.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "signature_plan"
        dgts.AllowSorting = False
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "signature_plan_date"
        col3.HeaderText = "签约日期"
        col3.Width = 70
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col3)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "status"
        col6.HeaderText = "签约状态"
        col6.Alignment = HorizontalAlignment.Left
        col6.Width = 70
        col6.NullText = String.Empty
        dgts.GridColumnStyles.Add(col6)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col2.MappingName = "place"
        col2.HeaderText = "地点"
        col2.Alignment = HorizontalAlignment.Left
        col2.NullText = String.Empty
        col2.Width = 120
        dgts.GridColumnStyles.Add(col2)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col5.MappingName = "remark"
        col5.HeaderText = "    备注"
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 300
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        dgList.TableStyles.Add(dgts)
    End Sub
    Private Sub Cancel(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = CType(sender, Button)

        If dsSig.HasChanges Then
            dsSig.RejectChanges()
        End If
        If btn Is btnNew Then
            btnNew.Text = "新 增(&N)"
            btnNew.Tag = "false"
        ElseIf btn Is btnModify Then
            btnModify.Text = "修 改(&M)"
            btnModify.Tag = "false"
        ElseIf btn Is btnSave Then
            If btnSave.Tag.ToString = "new" Then
                btnNew.Text = "新 增(&N)"
                btnNew.Tag = "false"
            ElseIf btnSave.Tag.ToString = "modify" Then
                btnModify.Text = "修 改(&M)"
                btnModify.Tag = "false"
            End If
        End If

        btnSave.Tag = "nothing"
        SetObjsEnabled(False)
        ReturnSigEachDay(mcDate.SelectedDate)

        If bmTemp.Count > 0 Then
            dgList.CurrentRowIndex = bmTemp.Count - 1
            dgList.Select(bmTemp.Count - 1)
        End If
    End Sub

    Private Sub SetObjsEnabled(ByVal IsEnabled As Boolean)
        txtAddress.Enabled = IsEnabled
        txtRemark.Enabled = IsEnabled : btnSave.Enabled = IsEnabled
        dgList.Enabled = Not IsEnabled
    End Sub

    Private Sub NewEvent(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        If Not btnNew.Tag Is Nothing Then
            If btnNew.Tag.ToString = "true" Then
                Cancel(sender, e)
                Return
            End If
        End If

        SetObjsEnabled(True)
        btnNew.Text = "取 消(&N)"
        btnNew.Tag = "true"
        btnSave.Tag = "new"
        btnModify.Enabled = False : btnDelete.Enabled = False
        txtAddress.Text = String.Empty : txtRemark.Text = String.Empty
        btnArrange.Enabled = False : btnCancelProject.Enabled = False
    End Sub
    Private Sub Modify(ByVal sender As Object, ByVal e As EventArgs) Handles btnModify.Click
        If Not btnModify.Tag Is Nothing Then
            If btnModify.Tag.ToString = "true" Then
                Cancel(sender, e)
                Return
            End If
        End If
        SetObjsEnabled(True)
        btnModify.Text = "取 消(&M)"
        btnModify.Tag = "true"
        btnSave.Tag = "modify"
        btnNew.Enabled = False : btnDelete.Enabled = False
        btnArrange.Enabled = False : btnCancelProject.Enabled = False
    End Sub
    Private Sub DeleteEvent(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If SWDialogBox.MessageBox.Show("?1004", CType(bmTemp.Current, DataRowView)("signature_plan_date")) = DialogResult.Yes Then
            Dim SigCode As Integer = CInt(CType(bmTemp.Current, DataRowView)("signature_plan_code"))
            Dim status As String = CStr(CType(bmTemp.Current, DataRowView)("status"))
            dsSig.Tables(0).Select("signature_plan_code=" & SigCode)(0).Delete()
            Dim strResult As String
            If status = "已提交" Then
                strResult = gWs.CancelSignaturePlan(SigCode)
            Else
                strResult = gWs.UpdateSignaturePlan(dsSig.GetChanges)
            End If
            If (strResult = "1") Then
                dsSig.AcceptChanges()
                SWDialogBox.MessageBox.Show("$DeleteSucceed")
                ReturnSigEachDay(mcDate.SelectedDate)
                If bmTemp.Count = 0 Then
                    mcDate.DeleteColorDate(mcDate.SelectedDate)
                    mcDate.UpdateColorDates()
                End If
            Else
                SWDialogBox.MessageBox.Show("*999", "撤销签约计划失败", strResult, "")
            End If
        End If
    End Sub
    Private Sub CancelProject(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelProject.Click
        Dim PC As String = CStr(CType(bmProject.Current, DataRowView)("ProjectCode"))
        Dim CorName As String = CStr(CType(bmProject.Current, DataRowView)("EnterpriseName"))
        'MessageBox.Show("确定将该项目(" & PC & "：" & CorName & ")从当前签约计划退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If SWDialogBox.MessageBox.Show("?X001", "(" & PC & "：" & CorName & ")") = DialogResult.No Then
            Return
        End If
        Dim result As String
        result = gWs.CancelSignaturePlanProject(PC)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "回退项目失败", result, "")
            'MessageBox.Show("回退项目失败" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim ds As DataSet = gWs.GetProjectSignatureInfo("{project_code LIKE '" & PC & "'}")
        ds.Tables(0).Rows(0)("signature_plan_code") = DBNull.Value
        result = gWs.UpdateProjectSignature(ds.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "修改项目失败", result, "")
            'MessageBox.Show("修改项目失败" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        bmTemp_PositionChanged(sender, e)
        RefreshMessage()
    End Sub
    Private IsWrong As Boolean = False
    Private Sub Save(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If mcDate.SelectedDate.Date < SystemDate.Date Then
            SWDialogBox.MessageBox.Show("$1003", "签约日期")
            'MessageBox.Show("所选日期不能小于""今天""", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If btnSave.Tag.ToString = "new" Then
            Dim dr As DataRow = dsSig.Tables("signature_plan").NewRow
            With dr
                .Item("signature_plan_date") = mcDate.SelectedDate.ToString("yyyy-MM-dd")
                .Item("remark") = txtRemark.Text
                .Item("place") = txtAddress.Text
                .Item("status") = "未提交"
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate.Date
            End With
            dsSig.Tables("signature_plan").Rows.Add(dr)
        ElseIf btnSave.Tag.ToString = "modify" Then
            Dim SigCode As Integer = CInt(CType(bmTemp.Current, DataRowView)("signature_plan_code"))
            With dsSig.Tables(0).Select("signature_plan_code=" & SigCode)(0)
                .Item("remark") = txtRemark.Text
                .Item("place") = txtAddress.Text
            End With
        End If

        Dim strResult As String = gWs.UpdateSignaturePlan(dsSig.GetChanges)
        If strResult = "1" Then
            IsWrong = False
            If sender Is Nothing Then Return

            SWDialogBox.MessageBox.Show("$SaveSucceed")
            'MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dsSig = gWs.GetSignaturePlanInfo("{signature_plan_date>='" & SystemDate.Date & "'}")
            bmSig = BindingContext(dsSig, "signature_plan")
            mcDate.AddColorDate(mcDate.SelectedDate)
            mcDate.UpdateColorDates()
        Else
            SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
            'MessageBox.Show("保存失败" & vbCr & strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IsWrong = True
            Return
        End If
        Cancel(sender, e)
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub
    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If Not btnSave.Tag Is Nothing Then
            If btnSave.Tag.ToString <> "nothing" Then
                Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003") 'MessageBox.Show("数据已修改，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If QueryResult = DialogResult.Yes Then
                    Save(Nothing, Nothing)
                    If IsWrong Then Return False
                ElseIf QueryResult = DialogResult.Cancel Then
                    Return False
                End If
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frmArrangeSign_Closing
        Close()
        Return True
    End Function

    Private Sub frmArrangeSign_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub

    Private Sub btnArrange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnArrange.Click
        Dim _SigCode As Integer = CInt(CType(bmTemp.Current, DataRowView)("signature_plan_code"))
        Dim _SigDate As String = CDate(CType(bmTemp.Current, DataRowView)("signature_plan_date")).ToString("yyyy-MM-dd")
        Dim _Address As String = MyIIf(CType(bmTemp.Current, DataRowView)("place"), GetType(String), "")
        Dim status As String = CStr(CType(bmTemp.Current, DataRowView)("status"))
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ofrmSigProject As frmSigProject = New frmSigProject(_SigDate, _Address, GetProjectList, _SigCode, IIf(status = "已提交", True, False))
            ofrmSigProject.Owner = Me
            AddHandler MyBase.Activated, AddressOf Me_Activated
            ofrmSigProject.StartPosition = FormStartPosition.CenterScreen
            ofrmSigProject.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RemoveHandler MyBase.Activated, AddressOf Me_Activated
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetProjectList() As String
        Dim ds As DataSet
        ds = gWs.GetTaskProjectList(TaskID, UserName)
        Dim result As String = ""
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            result += "'" & CStr(dr("ProjectCode")) & "',"
        Next
        If result <> "" Then
            result = result.Substring(0, result.Length - 1)
        End If
        Return result
    End Function

    Private Sub Me_Activated(ByVal sender As Object, ByVal e As EventArgs)
        If IsOwnedFormCommit Then
            RemoveHandler MyBase.Closing, AddressOf frmArrangeSign_Closing
            Close()
        End If
        RemoveHandler MyBase.Activated, AddressOf Me_Activated
    End Sub

End Class
