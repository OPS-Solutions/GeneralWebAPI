Public Class MainForm
	Public Shared mSettings As New Settings(AppDomain.CurrentDomain.BaseDirectory & "Settings.xml")

	Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnSetVars.Click
		SetVariableForm.Show()
	End Sub

	Private Sub btnRunMode_Click(sender As Object, e As EventArgs) Handles btnRunMode.Click
		LgsWebApi.RunMode()
	End Sub

	Private Sub btnDesignMode_Click(sender As Object, e As EventArgs) Handles btnDesignMode.Click
		LgsWebApi.DesignMode()
	End Sub

	Private Sub btnScript_Click(sender As Object, e As EventArgs) Handles btnScript.Click
		ScriptForm.Show()
	End Sub
End Class
