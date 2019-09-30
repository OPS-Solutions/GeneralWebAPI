Imports System.Net
Public Class LgsWebApi

	Public Shared Sub RunMode()
		POST("mode/run", "")
	End Sub
	Public Shared Sub DesignMode()
		POST("mode/design", "")
	End Sub
	Public Shared Sub SetVariable(ByVal Name As String, ByVal Value As String)
		POST("variables/set", "[{""Name"":""" & Name & """,""Value"":""" & Value & """}]")
	End Sub
	Public Shared Sub RunProgram(ByVal Name As String)
		POST("programs/run", "{""Name"":""" & Name & """}")
	End Sub
	Public Shared Sub RunProgram(ByVal Number As Integer)
		POST("programs/run", "{""Number"":""" & Number & """}")
	End Sub
	Public Shared Sub Abort()
		POST("programs/abort", "")
	End Sub


	Private Shared Sub POST(ByVal endpoint As String, Optional ByVal body As String = "")
		Try
			Dim full_url As String = MainForm.mSettings.URL & endpoint
			Dim wc As WebClient = New WebClient()
			wc.Headers.Set(HttpRequestHeader.ContentType, "application/json")
			wc.Headers.Set(HttpRequestHeader.Accept, "application/json")

			Dim result As String = wc.UploadString(full_url, "POST", body)

			wc.Dispose()
		Catch ex As Exception
			' TODO - how to notify user that exception happened???
		End Try
	End Sub
End Class
