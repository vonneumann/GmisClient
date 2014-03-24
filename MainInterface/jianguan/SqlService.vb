Imports System.Data
Imports System.Data.SqlClient
Public Class SqlService
    'Create by Daniel on 2013-8-23
    Private strSqlConn As String = "UID=sa;PWD=Xydb123456;Initial Catalog=XGMIS;Data Source=192.168.80.84\SQL2008"
    Private SqlConn As SqlClient.SqlConnection
    Public Sub New()
        strSqlConn = "UID=sa;PWD=Xydb123456;Initial Catalog=XGMIS;Data Source=192.168.80.84\SQL2008"
        Me.SqlConn = OpenDBConnect()
    End Sub
    Public Sub New(ByVal strSqlConn As String)
        Me.strSqlConn = strSqlConn
        Me.SqlConn = OpenDBConnect()
    End Sub
    
    Private Function OpenDBConnect() As SqlConnection
        If Me.SqlConn Is Nothing Then
            Me.SqlConn = New SqlConnection(Me.strSqlConn)
        End If
        If Me.SqlConn.State = ConnectionState.Closed Then
            Me.SqlConn.Open()
        End If
        Return Me.SqlConn
    End Function
    Public Sub CloseDBConnect()
        If Not (Me.SqlConn Is Nothing) And Me.SqlConn.State <> ConnectionState.Closed Then
            Me.SqlConn.Close()
        End If
    End Sub
    Public Function BuildSqlCommand(ByVal strSql As String, ByVal CmdType As CommandType, ByVal SqlParamList As ArrayList) As SqlCommand
        Dim Cmd As SqlCommand = New SqlCommand(strSql, OpenDBConnect())
        Cmd.CommandType = CmdType
        If Not SqlParamList Is Nothing Then
            For Each CmdParam As SqlParameter In SqlParamList
                Cmd.Parameters.Add(CmdParam)
            Next
        End If
        Return Cmd
    End Function
    Public Function GetEntityBean(ByVal strSql As String, ByVal strSqlType As CommandType, ByVal EntityBean As DataSet, ByVal TableName As String, ByVal SqlParamList As ArrayList) As DataSet
        Dim sqlCmd As SqlCommand = BuildSqlCommand(strSql, strSqlType, SqlParamList)
        Dim SqlTrans As SqlTransaction = Me.SqlConn.BeginTransaction()
        Dim DataAdapter As SqlDataAdapter = New SqlDataAdapter()
        With DataAdapter
            .SelectCommand = sqlCmd
            .SelectCommand.Transaction = SqlTrans
            .SelectCommand.CommandTimeout = 5000
            .Fill(EntityBean, TableName)
        End With
        SqlTrans.Commit()
        CloseDBConnect()
        Return EntityBean
    End Function
    Public Sub SaveEntityBean(ByVal strSql As String, ByVal EntityBean As DataSet, ByVal TableName As String)
        Dim DataAdapter As SqlDataAdapter = New SqlDataAdapter(strSql, OpenDBConnect())
        Dim sqlCmdBuilder As New SqlCommandBuilder(DataAdapter)
        DataAdapter.Update(EntityBean, TableName)
        CloseDBConnect()
    End Sub
    Public Sub UpdateEntityBean(ByVal strSql As String, ByVal strSqlType As CommandType, ByVal SqlParamList As ArrayList)
        Dim sqlCmd As SqlCommand = BuildSqlCommand(strSql, strSqlType, SqlParamList)
        Dim SqlTrans As SqlTransaction = Me.SqlConn.BeginTransaction()
        sqlCmd.Transaction = SqlTrans
        sqlCmd.CommandTimeout = 5000
        sqlCmd.ExecuteNonQuery()
        SqlTrans.Commit()
        CloseDBConnect()
    End Sub
    Public Sub UpdateRecordsBySP(ByVal Cmd As SqlCommand, ByVal SqlValueList As ArrayList)
        Dim i As Integer
        For i = 0 To SqlValueList.Count() - 1
            Cmd.Parameters(i).Value = SqlValueList(i)
        Next
        Cmd.ExecuteNonQuery()
        'CloseDBConnect()
    End Sub
    Public Function BuildSqlCommentParam(ByVal strSql As String, ByVal CmdType As CommandType, ByVal SqlParamList As ArrayList) As SqlCommand
        Dim i As Integer
        Dim Cmd As SqlCommand = New SqlCommand(strSql, OpenDBConnect())
        Cmd.CommandType = CmdType
        For i = 0 To SqlParamList.Count() - 1
            Cmd.Parameters.Add(SqlParamList(i))
        Next
        Return Cmd
    End Function
End Class
