<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOversee
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.StartDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.EndDate = New System.Windows.Forms.DateTimePicker
        Me.FixedRoleEnumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetOverseeInfo = New System.Windows.Forms.Button
        Me.FindCondition = New System.Windows.Forms.Panel
        Me.BankCredit = New System.Windows.Forms.TabPage
        Me.CreditByBank = New System.Windows.Forms.DataGridView
        Me.SubrogationInfo = New System.Windows.Forms.TabPage
        Me.SubrogationProjectList = New System.Windows.Forms.DataGridView
        Me.CompensateProjects = New System.Windows.Forms.TabPage
        Me.CompensateProjectList = New System.Windows.Forms.DataGridView
        Me.ReleaseProjects = New System.Windows.Forms.TabPage
        Me.ReleaseProjectList = New System.Windows.Forms.DataGridView
        Me.Clients = New System.Windows.Forms.TabPage
        Me.ClientList = New System.Windows.Forms.DataGridView
        Me.AbortProject = New System.Windows.Forms.TabPage
        Me.AbortProjectList = New System.Windows.Forms.DataGridView
        Me.LoanProjects = New System.Windows.Forms.TabPage
        Me.ReportedProjectHistory = New System.Windows.Forms.GroupBox
        Me.LoanProjectList = New System.Windows.Forms.DataGridView
        Me.CandidateProjects = New System.Windows.Forms.GroupBox
        Me.CandidateProjectList = New System.Windows.Forms.DataGridView
        Me.OverseeTab = New System.Windows.Forms.TabControl
        Me.SaveToXml = New System.Windows.Forms.Button
        Me.ExitOversee = New System.Windows.Forms.Button
        CType(Me.FixedRoleEnumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FindCondition.SuspendLayout()
        Me.BankCredit.SuspendLayout()
        CType(Me.CreditByBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubrogationInfo.SuspendLayout()
        CType(Me.SubrogationProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompensateProjects.SuspendLayout()
        CType(Me.CompensateProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReleaseProjects.SuspendLayout()
        CType(Me.ReleaseProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clients.SuspendLayout()
        CType(Me.ClientList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AbortProject.SuspendLayout()
        CType(Me.AbortProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoanProjects.SuspendLayout()
        Me.ReportedProjectHistory.SuspendLayout()
        CType(Me.LoanProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CandidateProjects.SuspendLayout()
        CType(Me.CandidateProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OverseeTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "申报起始日期"
        '
        'StartDate
        '
        Me.StartDate.CalendarFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.StartDate.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.StartDate.Location = New System.Drawing.Point(168, 8)
        Me.StartDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(160, 23)
        Me.StartDate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(571, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "申报截止日期"
        '
        'EndDate
        '
        Me.EndDate.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.EndDate.Location = New System.Drawing.Point(675, 11)
        Me.EndDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(153, 23)
        Me.EndDate.TabIndex = 6
        '
        'FixedRoleEnumBindingSource
        '
        Me.FixedRoleEnumBindingSource.DataSource = GetType(MainInterface.htfServerPermission.FixedRoleEnum)
        '
        'GetOverseeInfo
        '
        Me.GetOverseeInfo.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GetOverseeInfo.Location = New System.Drawing.Point(521, 607)
        Me.GetOverseeInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GetOverseeInfo.Name = "GetOverseeInfo"
        Me.GetOverseeInfo.Size = New System.Drawing.Size(100, 33)
        Me.GetOverseeInfo.TabIndex = 7
        Me.GetOverseeInfo.Text = "获取监管信息"
        Me.GetOverseeInfo.UseVisualStyleBackColor = True
        '
        'FindCondition
        '
        Me.FindCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FindCondition.Controls.Add(Me.Label1)
        Me.FindCondition.Controls.Add(Me.EndDate)
        Me.FindCondition.Controls.Add(Me.StartDate)
        Me.FindCondition.Controls.Add(Me.Label2)
        Me.FindCondition.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FindCondition.Location = New System.Drawing.Point(41, 12)
        Me.FindCondition.Name = "FindCondition"
        Me.FindCondition.Size = New System.Drawing.Size(895, 40)
        Me.FindCondition.TabIndex = 7
        '
        'BankCredit
        '
        Me.BankCredit.Controls.Add(Me.CreditByBank)
        Me.BankCredit.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BankCredit.Location = New System.Drawing.Point(4, 26)
        Me.BankCredit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BankCredit.Name = "BankCredit"
        Me.BankCredit.Size = New System.Drawing.Size(958, 503)
        Me.BankCredit.TabIndex = 6
        Me.BankCredit.Text = "银行授信"
        Me.BankCredit.UseVisualStyleBackColor = True
        '
        'CreditByBank
        '
        Me.CreditByBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreditByBank.Location = New System.Drawing.Point(4, 5)
        Me.CreditByBank.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CreditByBank.Name = "CreditByBank"
        Me.CreditByBank.RowTemplate.Height = 23
        Me.CreditByBank.Size = New System.Drawing.Size(1084, 495)
        Me.CreditByBank.TabIndex = 0
        '
        'SubrogationInfo
        '
        Me.SubrogationInfo.Controls.Add(Me.SubrogationProjectList)
        Me.SubrogationInfo.Location = New System.Drawing.Point(4, 26)
        Me.SubrogationInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SubrogationInfo.Name = "SubrogationInfo"
        Me.SubrogationInfo.Size = New System.Drawing.Size(958, 503)
        Me.SubrogationInfo.TabIndex = 5
        Me.SubrogationInfo.Text = "追偿信息"
        Me.SubrogationInfo.UseVisualStyleBackColor = True
        '
        'SubrogationProjectList
        '
        Me.SubrogationProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubrogationProjectList.Location = New System.Drawing.Point(3, 3)
        Me.SubrogationProjectList.Name = "SubrogationProjectList"
        Me.SubrogationProjectList.RowTemplate.Height = 23
        Me.SubrogationProjectList.Size = New System.Drawing.Size(952, 497)
        Me.SubrogationProjectList.TabIndex = 0
        '
        'CompensateProjects
        '
        Me.CompensateProjects.Controls.Add(Me.CompensateProjectList)
        Me.CompensateProjects.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CompensateProjects.Location = New System.Drawing.Point(4, 26)
        Me.CompensateProjects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CompensateProjects.Name = "CompensateProjects"
        Me.CompensateProjects.Size = New System.Drawing.Size(958, 503)
        Me.CompensateProjects.TabIndex = 4
        Me.CompensateProjects.Text = "代偿项目"
        Me.CompensateProjects.UseVisualStyleBackColor = True
        '
        'CompensateProjectList
        '
        Me.CompensateProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompensateProjectList.Location = New System.Drawing.Point(0, 3)
        Me.CompensateProjectList.Name = "CompensateProjectList"
        Me.CompensateProjectList.RowTemplate.Height = 23
        Me.CompensateProjectList.Size = New System.Drawing.Size(955, 497)
        Me.CompensateProjectList.TabIndex = 0
        '
        'ReleaseProjects
        '
        Me.ReleaseProjects.Controls.Add(Me.ReleaseProjectList)
        Me.ReleaseProjects.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ReleaseProjects.Location = New System.Drawing.Point(4, 26)
        Me.ReleaseProjects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReleaseProjects.Name = "ReleaseProjects"
        Me.ReleaseProjects.Size = New System.Drawing.Size(958, 503)
        Me.ReleaseProjects.TabIndex = 3
        Me.ReleaseProjects.Text = "解保项目"
        Me.ReleaseProjects.UseVisualStyleBackColor = True
        '
        'ReleaseProjectList
        '
        Me.ReleaseProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReleaseProjectList.Location = New System.Drawing.Point(3, 3)
        Me.ReleaseProjectList.Name = "ReleaseProjectList"
        Me.ReleaseProjectList.RowTemplate.Height = 23
        Me.ReleaseProjectList.Size = New System.Drawing.Size(955, 500)
        Me.ReleaseProjectList.TabIndex = 0
        Me.ReleaseProjectList.Tag = "解保项目"
        '
        'Clients
        '
        Me.Clients.Controls.Add(Me.ClientList)
        Me.Clients.Location = New System.Drawing.Point(4, 26)
        Me.Clients.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Clients.Name = "Clients"
        Me.Clients.Size = New System.Drawing.Size(958, 503)
        Me.Clients.TabIndex = 2
        Me.Clients.Text = "担保客户"
        Me.Clients.UseVisualStyleBackColor = True
        '
        'ClientList
        '
        Me.ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientList.Location = New System.Drawing.Point(3, 3)
        Me.ClientList.Name = "ClientList"
        Me.ClientList.RowTemplate.Height = 23
        Me.ClientList.Size = New System.Drawing.Size(955, 500)
        Me.ClientList.TabIndex = 0
        '
        'AbortProject
        '
        Me.AbortProject.Controls.Add(Me.AbortProjectList)
        Me.AbortProject.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AbortProject.Location = New System.Drawing.Point(4, 26)
        Me.AbortProject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AbortProject.Name = "AbortProject"
        Me.AbortProject.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AbortProject.Size = New System.Drawing.Size(958, 503)
        Me.AbortProject.TabIndex = 1
        Me.AbortProject.Text = "退保项目"
        Me.AbortProject.UseVisualStyleBackColor = True
        '
        'AbortProjectList
        '
        Me.AbortProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AbortProjectList.Location = New System.Drawing.Point(3, 3)
        Me.AbortProjectList.Name = "AbortProjectList"
        Me.AbortProjectList.RowTemplate.Height = 23
        Me.AbortProjectList.Size = New System.Drawing.Size(952, 497)
        Me.AbortProjectList.TabIndex = 0
        Me.AbortProjectList.Tag = "退保项目"
        '
        'LoanProjects
        '
        Me.LoanProjects.Controls.Add(Me.ReportedProjectHistory)
        Me.LoanProjects.Controls.Add(Me.CandidateProjects)
        Me.LoanProjects.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LoanProjects.Location = New System.Drawing.Point(4, 26)
        Me.LoanProjects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoanProjects.Name = "LoanProjects"
        Me.LoanProjects.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoanProjects.Size = New System.Drawing.Size(958, 503)
        Me.LoanProjects.TabIndex = 0
        Me.LoanProjects.Text = "担保项目"
        Me.LoanProjects.UseVisualStyleBackColor = True
        '
        'ReportedProjectHistory
        '
        Me.ReportedProjectHistory.Controls.Add(Me.LoanProjectList)
        Me.ReportedProjectHistory.Location = New System.Drawing.Point(3, 0)
        Me.ReportedProjectHistory.Name = "ReportedProjectHistory"
        Me.ReportedProjectHistory.Size = New System.Drawing.Size(955, 300)
        Me.ReportedProjectHistory.TabIndex = 7
        Me.ReportedProjectHistory.TabStop = False
        Me.ReportedProjectHistory.Text = "在保项目上报状态"
        '
        'LoanProjectList
        '
        Me.LoanProjectList.AllowUserToAddRows = False
        Me.LoanProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LoanProjectList.Location = New System.Drawing.Point(0, 24)
        Me.LoanProjectList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoanProjectList.Name = "LoanProjectList"
        Me.LoanProjectList.RowTemplate.Height = 23
        Me.LoanProjectList.Size = New System.Drawing.Size(955, 274)
        Me.LoanProjectList.TabIndex = 0
        '
        'CandidateProjects
        '
        Me.CandidateProjects.Controls.Add(Me.CandidateProjectList)
        Me.CandidateProjects.Location = New System.Drawing.Point(3, 306)
        Me.CandidateProjects.Name = "CandidateProjects"
        Me.CandidateProjects.Size = New System.Drawing.Size(952, 194)
        Me.CandidateProjects.TabIndex = 6
        Me.CandidateProjects.TabStop = False
        Me.CandidateProjects.Text = "本次上报项目"
        '
        'CandidateProjectList
        '
        Me.CandidateProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CandidateProjectList.Location = New System.Drawing.Point(0, 16)
        Me.CandidateProjectList.Name = "CandidateProjectList"
        Me.CandidateProjectList.RowTemplate.Height = 23
        Me.CandidateProjectList.Size = New System.Drawing.Size(948, 178)
        Me.CandidateProjectList.TabIndex = 5
        '
        'OverseeTab
        '
        Me.OverseeTab.Controls.Add(Me.LoanProjects)
        Me.OverseeTab.Controls.Add(Me.AbortProject)
        Me.OverseeTab.Controls.Add(Me.Clients)
        Me.OverseeTab.Controls.Add(Me.ReleaseProjects)
        Me.OverseeTab.Controls.Add(Me.CompensateProjects)
        Me.OverseeTab.Controls.Add(Me.SubrogationInfo)
        Me.OverseeTab.Controls.Add(Me.BankCredit)
        Me.OverseeTab.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.OverseeTab.Location = New System.Drawing.Point(26, 60)
        Me.OverseeTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OverseeTab.Name = "OverseeTab"
        Me.OverseeTab.SelectedIndex = 0
        Me.OverseeTab.Size = New System.Drawing.Size(966, 533)
        Me.OverseeTab.TabIndex = 0
        '
        'SaveToXml
        '
        Me.SaveToXml.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SaveToXml.Location = New System.Drawing.Point(689, 606)
        Me.SaveToXml.Name = "SaveToXml"
        Me.SaveToXml.Size = New System.Drawing.Size(100, 33)
        Me.SaveToXml.TabIndex = 8
        Me.SaveToXml.Text = "生成上报文件"
        Me.SaveToXml.UseVisualStyleBackColor = True
        '
        'ExitOversee
        '
        Me.ExitOversee.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ExitOversee.Location = New System.Drawing.Point(863, 606)
        Me.ExitOversee.Name = "ExitOversee"
        Me.ExitOversee.Size = New System.Drawing.Size(100, 33)
        Me.ExitOversee.TabIndex = 9
        Me.ExitOversee.Text = "退出"
        Me.ExitOversee.UseVisualStyleBackColor = True
        '
        'frmOversee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 651)
        Me.Controls.Add(Me.ExitOversee)
        Me.Controls.Add(Me.SaveToXml)
        Me.Controls.Add(Me.GetOverseeInfo)
        Me.Controls.Add(Me.FindCondition)
        Me.Controls.Add(Me.OverseeTab)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Location = New System.Drawing.Point(260, 50)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmOversee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "监管申报信息"
        CType(Me.FixedRoleEnumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FindCondition.ResumeLayout(False)
        Me.FindCondition.PerformLayout()
        Me.BankCredit.ResumeLayout(False)
        CType(Me.CreditByBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubrogationInfo.ResumeLayout(False)
        CType(Me.SubrogationProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompensateProjects.ResumeLayout(False)
        CType(Me.CompensateProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReleaseProjects.ResumeLayout(False)
        CType(Me.ReleaseProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clients.ResumeLayout(False)
        CType(Me.ClientList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AbortProject.ResumeLayout(False)
        CType(Me.AbortProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoanProjects.ResumeLayout(False)
        Me.ReportedProjectHistory.ResumeLayout(False)
        CType(Me.LoanProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CandidateProjects.ResumeLayout(False)
        CType(Me.CandidateProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OverseeTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FixedRoleEnumBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GetOverseeInfo As System.Windows.Forms.Button
    Friend WithEvents FindCondition As System.Windows.Forms.Panel
    Friend WithEvents BankCredit As System.Windows.Forms.TabPage
    Friend WithEvents CreditByBank As System.Windows.Forms.DataGridView
    Friend WithEvents SubrogationInfo As System.Windows.Forms.TabPage
    Friend WithEvents CompensateProjects As System.Windows.Forms.TabPage
    Friend WithEvents ReleaseProjects As System.Windows.Forms.TabPage
    Friend WithEvents ReleaseProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents Clients As System.Windows.Forms.TabPage
    Friend WithEvents ClientList As System.Windows.Forms.DataGridView
    Friend WithEvents AbortProject As System.Windows.Forms.TabPage
    Friend WithEvents AbortProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents LoanProjects As System.Windows.Forms.TabPage
    Friend WithEvents ReportedProjectHistory As System.Windows.Forms.GroupBox
    Friend WithEvents LoanProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents CandidateProjects As System.Windows.Forms.GroupBox
    Friend WithEvents CandidateProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents OverseeTab As System.Windows.Forms.TabControl
    Friend WithEvents CompensateProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents SubrogationProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents SaveToXml As System.Windows.Forms.Button
    Friend WithEvents ExitOversee As System.Windows.Forms.Button
End Class
