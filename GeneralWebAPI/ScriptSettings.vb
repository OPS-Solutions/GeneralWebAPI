Imports System.IO

Public Class ScriptSettings
	Public Lines As String
	Private mPath As String

	<DebuggerStepThrough()> Public Sub New()
	End Sub
	Public Sub New(ByVal filePath As String)
		mPath = filePath

		If Not System.IO.File.Exists(mPath) Then
			InitializeEmptyFile()
		End If

		Try
			Using fs As FileStream = New FileStream(mPath, FileMode.Open, FileAccess.Read)
				Using sr As New StreamReader(fs) 'Must use XmlTextReader or else cr will be deleted from values
					Me.Lines = sr.ReadToEnd
				End Using
			End Using
		Catch ex As Exception
			Throw New Exception($"{ex.Message.Split(vbCr)(0)} check this (row,column) in {mPath}")
		End Try
	End Sub

	Private Sub InitializeEmptyFile()
		Try
			Me.Lines = $"ModeRun{vbCrLf}Wait 2000{vbCrLf}ModeDesign{vbCrLf}Wait 2000{vbCrLf}ModeRun{vbCrLf}Wait 2000{vbCrLf}ModeDesign{vbCrLf}Wait 2000{vbCrLf}ModeRun{vbCrLf}Wait 2000{vbCrLf}ModeDesign"
			WriteToFile(mPath)
		Catch ex As Exception

		End Try
	End Sub

	Public Sub WriteToFile(ByVal filePath As String)
		If Not IO.Directory.Exists(Path.GetDirectoryName(filePath)) Then
			IO.Directory.CreateDirectory(Path.GetDirectoryName(filePath))
		End If

		Using fs As New FileStream(filePath, FileMode.Create, FileAccess.Write)
			Using sr As StreamWriter = New StreamWriter(fs)
				sr.Write(Me.Lines)
				sr.Close()
				fs.Close()
			End Using
		End Using
	End Sub
End Class