Imports System.Windows
Public Interface IApplyTool
    Sub OpenApplyTool(ByVal strProjectCode As String, ByVal strCorpName As String, ByVal strWorkFlowId As String, ByVal strTaskId As String, ByVal frmOwner As Form, ByVal strUser As String)
    Sub OpenApplyTool(ByVal strProjectCode As String, ByVal strCorpName As String, ByVal strWorkFlowId As String, ByVal strTaskId As String, ByVal frmOwner As Form, ByVal strUser As String, ByVal taskName As String, ByVal roleID As String)
    Event CommitSucceed()
End Interface
