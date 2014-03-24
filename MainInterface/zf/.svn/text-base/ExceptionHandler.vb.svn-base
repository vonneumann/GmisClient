Public Class ExceptionHandler
    Public Const UNKNOWNERROR As String = "*999"

    Private _logFile As String

    Public Sub New()
        '初始化系统默认日志文件名称。
        _logFile = System.IO.Path.Combine(System.Environment.CurrentDirectory, System.Reflection.Assembly.GetEntryAssembly().GetName().Name + ".log")
    End Sub

    Public Sub New(ByVal logFile As String)
        _logFile = logFile
    End Sub

    Public Property LogFile() As String
        Get
            Return _logFile
        End Get
        Set(ByVal Value As String)
            _logFile = Value
        End Set
    End Property

    '/// <summary>
    '/// 将指定的异常信息写入系统默认的日志文件。
    '/// </summary>
    '/// <param name="ex">要记录的异常对象。</param>
    '/// <returns></returns>
    Public Function WriteLog(ByVal ex As System.Exception) As String
        Return ExceptionHandler.WriteLog(ex, _logFile)
    End Function

    '/// <summary>
    '/// 将指定的异常信息写入指定的日志文件。
    '/// </summary>
    '/// <param name="ex">要记录的异常对象。</param>
    '/// <param name="fileName">指定的日志文件名。</param>
    '/// <returns></returns>
    Public Shared Function WriteLog(ByVal sourceException As System.Exception, ByVal fileName As String) As String
        Try
            Dim logEntry As SWSystem.XML.XMLLogEntry = SWSystem.XML.XMLLog.GetLogEntry(sourceException.Source, sourceException.Message, SWSystem.XML.XMLLogEntryType.Error, sourceException, "Exception")

            logEntry.Properties.Add("OS", System.Environment.OSVersion.Platform.ToString() + "[" + System.Environment.OSVersion.Version.ToString() + "]")
            logEntry.Properties.Add("CallAssembly", System.Reflection.Assembly.GetCallingAssembly().FullName)
            logEntry.Properties.Add("CommandLine", System.Environment.CommandLine)
            logEntry.Properties.Add("StackTrace", System.Environment.StackTrace)

            If (fileName Is Nothing OrElse fileName.Trim() = String.Empty) Then
                fileName = System.IO.Path.Combine(System.Environment.CurrentDirectory, System.Reflection.Assembly.GetEntryAssembly().GetName().Name + ".log")
            End If

            SWSystem.XML.XMLLog.WriteLog(fileName, logEntry)

            Return logEntry.ID
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("系统无法更新日志文件，请即时与您的系统管理员或我们联系！" + System.Environment.NewLine + System.Environment.NewLine + "异常来源：" + ex.Source + "[" + ex.GetType().FullName + "]" + Environment.NewLine + "异常消息：" + ex.Message, "系统异常", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try

        Return Nothing
    End Function

    '/// <summary>
    '/// 根据指定的异常对象显示相应的消息框。
    '/// </summary>
    '/// <param name="sourceException">要显示信息的来源异常对象。</param>
    '/// <remarks>
    '/// 如果参数 <see cref="sourceException">sourceException</see> 异常是SoapException，则用 <seealso cref="SWSystem.XML.XMLLogEntry">SWSystem.XML.XMLLogEntry</seealso> 类来解析其 <c>Detail</c> 属性以获得原始的异常对象，如果获取成功则将该异常作为来源异常。
    '/// 如果参数 <see cref="sourceException">sourceException</see> 是未知异常类型或 <seealso cref="System.Exception">System.Exception</seealso> 类型，则显示系统未知异常并将该异常写入系统默认日志。
    '/// </remarks>
    Public Overridable Overloads Sub ShowMessageBoxEx(ByVal sourceException As System.Exception)
        Try
            If (sourceException Is Nothing) Then
                Return
            End If

            Dim ex As System.Web.Services.Protocols.SoapException = Nothing

            If TypeOf sourceException Is System.Web.Services.Protocols.SoapException Then
                ex = CType(sourceException, System.Web.Services.Protocols.SoapException)
            End If

            If (Not ex Is Nothing) Then
                Dim logEntry As SWSystem.XML.XMLLogEntry = New SWSystem.XML.XMLLogEntry(ex.Detail.SelectSingleNode("logEntry"))

                If ((Not logEntry.Data Is Nothing) AndAlso TypeOf logEntry.Data Is System.Exception) Then
                    Throw CType(logEntry.Data, System.Exception)
                End If
            End If

            Throw sourceException
        Catch ex As System.ArgumentNullException
            If (Not Me.ShowMessageBox("$1234", ex.Source + "[" + ex.GetType().FullName + "]", ex.Message, ex.StackTrace)) Then
                Me.WriteLog(ex)
            End If
        Catch ex As System.Exception
            Me.ShowMessageBox(UNKNOWNERROR, ex.Source + "[" + ex.GetType().FullName + "]", ex.Message, ex.StackTrace)

            ExceptionHandler.WriteLog(ex, Nothing)
        End Try
    End Sub

    '/// <summary>
    '/// 私有方法。显示消息框，加入处理显示消息框的异常处理。
    '/// </summary>
    '/// <param name="messageID">显示的消息编号。</param>
    '/// <param name="args">显示的消息参数。</param>
    '/// <returns>如果显示指定消息的消息框成功，则为 true；否则为 false。</returns>
    '/// <remarks>如果调用消息框显示函数出错则显示一个错误信息框并将该异常记录到系统默认日志文件。</remarks>
    Private Overloads Function ShowMessageBox(ByVal messageID As String, ByVal ParamArray args As Object()) As Boolean
        Try
            SWDialogBox.MessageBox.Show(messageID, args)
            Return True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("显示消息框 [" + messageID + "] 出错！" + System.Environment.NewLine + System.Environment.NewLine + _
                      "错误来源：" + ex.Source + System.Environment.NewLine + _
                      "错误消息：" + ex.Message, "系统异常", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)

            Me.WriteLog(ex)
        End Try

        Return False
    End Function

    Public Overloads Shared Function ShowMessageBox(ByVal ex As System.Exception)
        SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
    End Function
End Class
