<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOverseeFinanceInfo
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
        Me.Finance = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Balance = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Income = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.CashFlow = New System.Windows.Forms.DataGridView
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.CashFlowSchedule = New System.Windows.Forms.DataGridView
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.AccountBalance = New System.Windows.Forms.DataGridView
        Me.ReportPeriod = New System.Windows.Forms.TextBox
        Me.FPeriod = New System.Windows.Forms.Label
        Me.OperateArea = New System.Windows.Forms.Panel
        Me.ExtButtom = New System.Windows.Forms.Button
        Me.GeneratePacket = New System.Windows.Forms.Button
        Me.Finance.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Balance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Income, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.CashFlow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.CashFlowSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.AccountBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OperateArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'Finance
        '
        Me.Finance.Controls.Add(Me.TabPage1)
        Me.Finance.Controls.Add(Me.TabPage2)
        Me.Finance.Controls.Add(Me.TabPage3)
        Me.Finance.Controls.Add(Me.TabPage4)
        Me.Finance.Controls.Add(Me.TabPage5)
        Me.Finance.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Finance.Location = New System.Drawing.Point(34, 72)
        Me.Finance.Name = "Finance"
        Me.Finance.SelectedIndex = 0
        Me.Finance.Size = New System.Drawing.Size(966, 623)
        Me.Finance.TabIndex = 0
        Me.Finance.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Balance)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(958, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "资产负债表"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Balance
        '
        Me.Balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Balance.Location = New System.Drawing.Point(3, 0)
        Me.Balance.Name = "Balance"
        Me.Balance.RowTemplate.Height = 23
        Me.Balance.Size = New System.Drawing.Size(955, 500)
        Me.Balance.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Income)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(958, 503)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "损益表"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Income
        '
        Me.Income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Income.Location = New System.Drawing.Point(0, 0)
        Me.Income.Name = "Income"
        Me.Income.RowTemplate.Height = 23
        Me.Income.Size = New System.Drawing.Size(955, 500)
        Me.Income.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CashFlow)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(958, 503)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "现金流量表"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CashFlow
        '
        Me.CashFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CashFlow.Location = New System.Drawing.Point(0, 0)
        Me.CashFlow.Name = "CashFlow"
        Me.CashFlow.RowTemplate.Height = 23
        Me.CashFlow.Size = New System.Drawing.Size(955, 500)
        Me.CashFlow.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CashFlowSchedule)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(958, 503)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "现金流量表附表"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CashFlowSchedule
        '
        Me.CashFlowSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CashFlowSchedule.Location = New System.Drawing.Point(0, 0)
        Me.CashFlowSchedule.Name = "CashFlowSchedule"
        Me.CashFlowSchedule.RowTemplate.Height = 23
        Me.CashFlowSchedule.Size = New System.Drawing.Size(955, 600)
        Me.CashFlowSchedule.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.AccountBalance)
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(958, 593)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "科目余额表"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'AccountBalance
        '
        Me.AccountBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountBalance.Location = New System.Drawing.Point(3, 3)
        Me.AccountBalance.Name = "AccountBalance"
        Me.AccountBalance.RowTemplate.Height = 23
        Me.AccountBalance.Size = New System.Drawing.Size(952, 587)
        Me.AccountBalance.TabIndex = 0
        '
        'ReportPeriod
        '
        Me.ReportPeriod.AcceptsTab = True
        Me.ReportPeriod.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ReportPeriod.Location = New System.Drawing.Point(132, 10)
        Me.ReportPeriod.Name = "ReportPeriod"
        Me.ReportPeriod.Size = New System.Drawing.Size(125, 25)
        Me.ReportPeriod.TabIndex = 1
        '
        'FPeriod
        '
        Me.FPeriod.AutoSize = True
        Me.FPeriod.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FPeriod.Location = New System.Drawing.Point(31, 13)
        Me.FPeriod.Name = "FPeriod"
        Me.FPeriod.Size = New System.Drawing.Size(61, 19)
        Me.FPeriod.TabIndex = 2
        Me.FPeriod.Text = "报表期次"
        '
        'OperateArea
        '
        Me.OperateArea.BackColor = System.Drawing.Color.SlateGray
        Me.OperateArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OperateArea.Controls.Add(Me.ExtButtom)
        Me.OperateArea.Controls.Add(Me.GeneratePacket)
        Me.OperateArea.Controls.Add(Me.FPeriod)
        Me.OperateArea.Controls.Add(Me.ReportPeriod)
        Me.OperateArea.Location = New System.Drawing.Point(38, 5)
        Me.OperateArea.Name = "OperateArea"
        Me.OperateArea.Size = New System.Drawing.Size(962, 52)
        Me.OperateArea.TabIndex = 3
        '
        'ExtButtom
        '
        Me.ExtButtom.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExtButtom.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ExtButtom.Location = New System.Drawing.Point(774, 5)
        Me.ExtButtom.Name = "ExtButtom"
        Me.ExtButtom.Size = New System.Drawing.Size(108, 36)
        Me.ExtButtom.TabIndex = 4
        Me.ExtButtom.Text = "退出"
        Me.ExtButtom.UseVisualStyleBackColor = False
        '
        'GeneratePacket
        '
        Me.GeneratePacket.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GeneratePacket.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GeneratePacket.Location = New System.Drawing.Point(581, 3)
        Me.GeneratePacket.Name = "GeneratePacket"
        Me.GeneratePacket.Size = New System.Drawing.Size(108, 36)
        Me.GeneratePacket.TabIndex = 3
        Me.GeneratePacket.Text = "生成上报文件"
        Me.GeneratePacket.UseVisualStyleBackColor = False
        '
        'FrmOverseeFinanceInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 761)
        Me.Controls.Add(Me.OperateArea)
        Me.Controls.Add(Me.Finance)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Location = New System.Drawing.Point(260, 50)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmOverseeFinanceInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "担保机构财务信息"
        Me.Finance.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Balance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Income, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.CashFlow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.CashFlowSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.AccountBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OperateArea.ResumeLayout(False)
        Me.OperateArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Finance As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ReportPeriod As System.Windows.Forms.TextBox
    Friend WithEvents FPeriod As System.Windows.Forms.Label
    Friend WithEvents Balance As System.Windows.Forms.DataGridView
    Friend WithEvents Income As System.Windows.Forms.DataGridView
    Friend WithEvents CashFlow As System.Windows.Forms.DataGridView
    Friend WithEvents CashFlowSchedule As System.Windows.Forms.DataGridView
    Friend WithEvents AccountBalance As System.Windows.Forms.DataGridView
    Friend WithEvents OperateArea As System.Windows.Forms.Panel
    Friend WithEvents ExtButtom As System.Windows.Forms.Button
    Friend WithEvents GeneratePacket As System.Windows.Forms.Button
End Class
