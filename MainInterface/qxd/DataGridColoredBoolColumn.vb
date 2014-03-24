
'
    'qxd 2003-5-13  整理
    '

    '委托
Public Delegate Function delegateGetColorRowColBool(ByVal row As Integer, ByVal col As Integer) As Color

Public Class DataGridColoredBoolColumn
    Inherits DataGridBoolColumn

    Private _getColorRowCol As delegateGetColorRowColBool
    Private _column As Integer

    Public Sub New()
        MyBase.New()
    End Sub
    '构造函数
    Public Sub New(ByVal getcolorRowCol As delegateGetColorRowColBool, ByVal column As Integer)
        _getColorRowCol = getcolorRowCol
        _column = column
    End Sub
    '重写Paint，重画
    Protected Overloads Overrides Sub Paint(ByVal g As System.Drawing.Graphics, ByVal bounds As System.Drawing.Rectangle, ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal backBrush As System.Drawing.Brush, ByVal foreBrush As System.Drawing.Brush, ByVal alignToRight As Boolean)
        ' the idea is to conditionally set the foreBrush and/or backbrush
        ' depending upon some crireria on the cell value
        ' Here, we use a delegate to retrieve the color
        Try
            backBrush = New SolidBrush(_getColorRowCol(rowNum, Me._column))
            foreBrush = New SolidBrush(Color.Black)
        Catch ex As Exception
        Finally
            ' make sure the base class gets called to do the drawing with
            ' the possibly changed brushes
            MyBase.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight)
        End Try
    End Sub
    '设置列的颜色
    Public Function MyGetColorRowCol(ByVal row As Integer, ByVal col As Integer) As Color

        ' just conditionally set colors based on row, col values...
        Dim c As Color
        If col = 0 Then
            c = Color.LightYellow
        ElseIf col = 1 Then
            c = Color.LightBlue
        Else
            c = Color.White
        End If
        Return c
    End Function

End Class
