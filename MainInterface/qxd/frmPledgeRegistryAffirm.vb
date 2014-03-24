Public Class frmPledgeRegistryAffirm
    Inherits MainInterface.frmWardAffirm

    Public Sub New()
        MyBase.New()
        Me.Text = "质押手续确认"
    End Sub

    Public Sub New(ByVal projectCode As String, ByVal isOnlyView As Boolean)
        MyBase.new(projectCode, isOnlyView)
        Me.Text = "质押手续确认"
    End Sub
End Class