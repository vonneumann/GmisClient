Public Class frmRegistryAffirm
    Inherits MainInterface.frmWardAffirm

    Public Sub New()
        MyBase.New()
        Me.Text = "抵押手续确认"
    End Sub

    Public Sub New(ByVal projectCode As String, ByVal isOnlyView As Boolean)
        MyBase.new(projectCode, isOnlyView)
        Me.Text = "抵押手续确认"
    End Sub
End Class