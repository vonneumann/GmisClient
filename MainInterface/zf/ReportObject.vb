Imports CrystalDecisions
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class ReportObject
	Public Enum ExportOptions
		NoFormat
		CrystalReport
		RichText
		WordForWindows
		Excel
		PortableDocFormat
		HTML32
		HTML40
	End Enum

	Private _dataSource As Object
	Private _reportFile As String
	Private _reportTitle As String

	Public Property DataSource() As Object
		Get
			Return _dataSource
		End Get
		Set(ByVal Value As Object)
			_dataSource = Value
		End Set
	End Property

	Public Property ReportFile() As String
		Get
			Return _reportFile
		End Get
		Set(ByVal Value As String)
			_reportFile = Value
		End Set
	End Property

	Public Property ReportTitle() As String
		Get
			Return _reportTitle
		End Get
		Set(ByVal Value As String)
			_reportTitle = Value
		End Set
	End Property

	Public Sub Export()
		Dim dlgExport As SaveFileDialog = New SaveFileDialog()

		Dim exportFormat As ReportObject.ExportOptions

		dlgExport.Filter = "水晶报表文件|*.rpt|RichText 文件|*.rtf|Word 文件|*.doc|Excel 文件|*.xls|PDF 文件|*.pdf|HTML32 文件|*.htm,*.html|HTML40 文件|*.htm,*.html"
		dlgExport.Title = "导出文件"
		dlgExport.FilterIndex = 4

		If dlgExport.ShowDialog() = DialogResult.OK And dlgExport.FileName.Trim() <> "" Then
			exportFormat = CType(dlgExport.FilterIndex, ReportObject.ExportOptions)

			Export(dlgExport.FileName, exportFormat)
		End If
	End Sub

	Public Sub Export(ByVal exportFile As String, ByVal exportFormat As ExportOptions)
		Try
			Dim reportDocument As CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
			Dim exportOptions As CrystalDecisions.Shared.ExportOptions = New CrystalDecisions.Shared.ExportOptions()

			reportDocument.Load(_reportFile)
			reportDocument.SetDataSource(_dataSource)
			If Not ReportTitle Is Nothing Then
				reportDocument.SummaryInfo.ReportTitle = _reportTitle
			End If

			exportOptions = reportDocument.ExportOptions
			exportOptions.ExportFormatType = exportFormat
			exportOptions.ExportDestinationType = ExportDestinationType.DiskFile
			exportOptions.DestinationOptions = New DiskFileDestinationOptions()
			CType(exportOptions.DestinationOptions, DiskFileDestinationOptions).DiskFileName = exportFile

			reportDocument.Export()
			reportDocument.Close()
			reportDocument.Dispose()
		Catch ex As CrystalDecisions.CrystalReports.Engine.LoadSaveReportException
			MessageBox.Show("不能加载指定的报表（" + _reportFile + "），请确认指定的报表文件是否存在，然后再重新执行该操作。", "报表导出", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		Catch ex As CrystalDecisions.CrystalReports.Engine.FormattingException
			MessageBox.Show("不能导出到指定的格式，请重新指定一个系统支持的导出格式。", "报表导出")
			Return
		End Try
	End Sub
End Class
