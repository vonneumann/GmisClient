Imports System.Text.RegularExpressions
Imports System.Globalization

Module CGModule
    '
    '变量传输列表(8/27/2003)
    '
    'added by Michael 8/27/2003
    'Public Corpation_Code As String
    'Public Project_code As String
    'Public Phase_Code As String
    'added end

    '
    '通用全字符串匹配
    '
    Function ValidCheck(ByVal vc As String, ByVal format As String) As Boolean
        Dim r As New Regex(format)
        Dim mt As Match = r.Match(vc)
        Return mt.Length = vc.Length
    End Function

    '
    'Web站点格式
    '
    Function WebSiteValid(ByVal webSite As String) As Boolean
        Return ValidCheck(webSite, "((?:http|HTTP)://)?[\w-]+(\.[\w-]+)*([\w\/\?&%])*")
    End Function

    '
    '货币格式200,0000.00格式
    '
    Function CurrencyValid(ByVal currency As String) As Boolean
        Return ValidCheck(currency, "\d*(,\d{4})*(\.\d{2})?")
    End Function

    Private cg_FormatInfo As NumberFormatInfo
    ReadOnly Property CGFormatInfo() As NumberFormatInfo
        Get
            If cg_FormatInfo Is Nothing Then
                cg_FormatInfo = New NumberFormatInfo()
                cg_FormatInfo.CurrencySymbol = ""
                cg_FormatInfo.CurrencyNegativePattern = 1
            End If
            Return cg_FormatInfo
        End Get
    End Property
    '
    '将货币格式转化为numeric
    '
    Function Currency2Numeric(ByVal currency As String) As Decimal
        If currency = "" Then currency = "0"
        If currency.IndexOf(",") = 0 Then
            If currency.Length > 1 Then
                Return CType(currency.Substring(1), Decimal)
            Else
                Return 0
            End If
        Else
            Return CType(currency, Decimal)
        End If
    End Function
    '
    '将货币格式转化为double
    '
    Function Currency2Double(ByVal currency As String) As Double
        If currency = "" Then currency = "0"
        Return CDbl(currency)
    End Function
    '
    '将数字串转化为货币格式的
    '
    Function Numeric2Currency(ByVal num As String) As String
        Return CType(num, Decimal).ToString("c", CGFormatInfo)
    End Function
    '
    '转化控件的显示值为货币格式
    '
    Sub ShowCurrency(ByVal sender As Object, ByVal e As EventArgs)
        Dim he As TextBox
        Try
            he = CType(sender, TextBox)
            If he.Text = "" Then Return
            he.Text = Numeric2Currency(he.Text)
        Catch
            he.Text = ""
        End Try
    End Sub
    '
    '
    '
    Sub CFormatTextBox(ByVal sender As Object)
        Dim he As TextBox = CType(sender, TextBox)
        If he.Text = "" Then Return
        he.Text = Numeric2Currency(he.Text)
    End Sub
    '
    '企业代码 - 5位数字
    '
    Function CorpCodeValid(ByVal code As String) As Boolean
        Return ValidCheck(code, "\d{5}")
    End Function

    '
    '电话号码区号3-4位，加-号分解，加电话号码7-8位
    '
    Function PhoneNumberValid(ByVal number As String) As Boolean
        Return ValidCheck(number, "(\d{3,4}-)?\d{7,8}")
    End Function

    '
    '传真
    '
    Function FaxValid(ByVal fax As String) As Boolean
        Return PhoneNumberValid(fax)
    End Function

    '
    '手机号码国家代码086，加-号分解，号码11位
    '
    Function MobileValid(ByVal mobile As String) As Boolean
        Return ValidCheck(mobile, "(\d{3,4}-)?\d{11}")
    End Function

    '
    'Email格式
    '
    Function EmailValid(ByVal email As String) As Boolean
        Return ValidCheck(email, "[\w-]+@[\w-]+(\.[\w-]+)+")
    End Function
End Module
