Public Interface IFunction
    Function Support(ByVal functionID As String) As Boolean
End Interface

Public Interface IDataService
    Sub Clear()
    Sub Delete(ByVal args As Object())
    Sub Insert(ByVal args As Object())
    Function Update(ByVal args As Object()) As Boolean
    Sub Refresh(ByVal args As Object())
End Interface

Public Interface IPrintService
    Sub Preview()
    Sub Print()
End Interface

Public Interface IEditService
    Sub Cut()
    Sub Copy()
    Sub Paste()
    'Sub Find(ByVal text As String)
    'Sub Replace(ByVal source As String, ByVal d As String)
End Interface

Public Interface ICommonService
    Function Support(ByVal functionID As String) As Boolean
    Function GetArguments(ByVal functionID As String) As Object()
    Function Invoke(ByVal functionID As String) As Object
    Function Invoke(ByVal functionID As String, ByVal args As Object()) As Object
End Interface