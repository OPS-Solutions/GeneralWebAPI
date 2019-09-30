Imports System.Xml.Serialization
Imports System.IO
Imports System.Xml
<Serializable()>
<XmlRoot("SetVariables", Namespace:="http://tempuri.org/SetVariables.xsd")>
Public Class SetVariableSettings
	<XmlElement("Variable")>
	Public Variables As New List(Of Variable)
	Private mPath As String

	<DebuggerStepThrough()> Public Sub New()
	End Sub
	Public Sub New(ByVal filePath As String)
		mPath = filePath

		If Not System.IO.File.Exists(mPath) Then
			InitializeEmptyFile()
		End If

		Try
			Using fileStream As FileStream = New FileStream(mPath, FileMode.Open, FileAccess.Read)
				Using streamReader As XmlTextReader = New XmlTextReader(fileStream) 'Must use XmlTextReader or else cr will be deleted from values
					Dim XmlSerializer As New XmlSerializer(GetType(SetVariableSettings))
					Me.Variables = XmlSerializer.Deserialize(streamReader).Variables
				End Using
			End Using
		Catch ex As Exception
			Throw New Exception($"{ex.Message.Split(vbCr)(0)} check this (row,column) in {mPath}")
		End Try
	End Sub

	Private Sub InitializeEmptyFile()
		Try
			Me.Variables.Add(New Variable With {.Name = "Test", .Value = "hello world"})
			WriteToXml(mPath)
		Catch ex As Exception

		End Try
	End Sub

	Public Sub WriteToXml(ByVal filePath As String)
		If Not IO.Directory.Exists(Path.GetDirectoryName(filePath)) Then
			IO.Directory.CreateDirectory(Path.GetDirectoryName(filePath))
		End If
		Dim xmlSerializer As New XmlSerializer(GetType(SetVariableSettings))
		Using fileStream As FileStream = New FileStream(filePath, FileMode.Create, FileAccess.Write)
			Using streamReader As StreamWriter = New StreamWriter(fileStream)
				xmlSerializer.Serialize(streamReader, Me)
				streamReader.Close()
				fileStream.Close()
			End Using
		End Using
	End Sub
End Class

<Serializable()>
Public Class Variable
	<XmlElement("Name")>
	Public Name As String
	<XmlElement("Value")>
	Public Value As String
End Class