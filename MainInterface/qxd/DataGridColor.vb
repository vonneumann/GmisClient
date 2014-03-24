
Public Class DataGridColor
    Inherits DataGridTextBoxColumn

    Public Delegate Function delegateGetColorRowCol(ByVal row As Integer, ByVal col As Integer) As Color

    Private _getColorRowCol As delegateGetColorRowCol
    Private _column As Integer

    Public Sub New()

    End Sub
    Public Sub New(ByVal getcolorRowCol As delegateGetColorRowCol, ByVal column As Integer)
        _getColorRowCol = getcolorRowCol
        _column = column
    End Sub

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
    Public Function MyGetColorRowCol(ByVal row As Integer, ByVal col As Integer) As Color

        ' just conditionally set colors based on row, col values...
        Dim c As Color = Color.LightGreen
        If (col Mod 2 = 0) Then
            c = Color.Goldenrod
        End If

        If ((row + col) Mod 5 = 0) Then
            c = Color.Pink
        ElseIf ((row + col) Mod 3 = 0) Then
            c = Color.BlueViolet
        End If
        Return c
    End Function
End Class

