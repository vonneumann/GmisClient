Imports System.Xml

Namespace SWConsole
	Public Class Configuration
		Public Shared Function GetAppValue(ByVal key As String) As String
			Try
				Return GetAppValue(key, GetType(System.String))
			Catch ex As System.Exception
				Throw ex
			End Try
		End Function

		Public Shared Function GetAppValue(ByVal key As String, ByVal type As System.Type) As Object
			Try
				Dim app As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()

				Return app.GetValue(key, type)
			Catch ex As System.Exception
				Throw ex
			End Try
		End Function

		Public Shared Sub SetAppValue(ByVal key As String, ByVal value As Object, ByVal isCreate As Boolean)
			Try
				Dim doc As XmlDocument = New XmlDocument()
				Dim app As XmlElement
				Dim node As XmlNode

				doc.Load(Application.ExecutablePath + ".config")
				app = doc.DocumentElement.Item("appSettings")

				If app Is Nothing Then
					app = doc.CreateElement("appSettings")
				End If

				node = app.SelectSingleNode("child::add[@key='" + key + "']")

				If node Is Nothing Then
					node = doc.CreateNode(XmlNodeType.Element, "add", Nothing)
					app.AppendChild(node)

					Dim att As XmlAttribute
					att = node.Attributes.Append(doc.CreateAttribute("key"))
					att.Value = key
					att = node.Attributes.Append(doc.CreateAttribute("value"))
					att.Value = value
				End If

				node.Attributes.ItemOf("value").Value = value
				doc.Save(Application.ExecutablePath + ".config")
			Catch ex As System.Exception
				Throw ex
			End Try
		End Sub
	End Class
End Namespace