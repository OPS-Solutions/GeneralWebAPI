Public Class ScriptForm
	Dim mSettingsName As String
	Dim mSettings As ScriptSettings

	Private Sub SetVariableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		mSettingsName = My.Settings.ScriptPath

		If String.IsNullOrWhiteSpace(mSettingsName) Then
			mSettingsName = AppDomain.CurrentDomain.BaseDirectory & "Scripts\Default Script.txt"
		End If

		mSettings = New ScriptSettings(mSettingsName)
		PopulateControls()

		Me.lblFile.Text = mSettingsName
	End Sub
	Private Sub PopulateControls()
		Me.txtScript.Text = mSettings.Lines
	End Sub

	Private Sub SetVariableButtonEventHandler(ByVal sender As Object, ByVal e As EventArgs)
		Dim sender_button As Button = CType(sender, Button)
		Dim strNumber As String = sender_button.Name.Substring(14)
		Dim txtName As TextBox = Controls("txtSetVariableName" & strNumber)
		Dim txtValue As TextBox = Controls("txtSetVariableValue" & strNumber)
		LgsWebApi.SetVariable(txtName.Text, txtValue.Text)
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		Try

			mSettings.Lines = Me.txtScript.Text

			Using dial As New SaveFileDialog
				dial.AddExtension = True
				dial.CreatePrompt = False
				dial.DefaultExt = ".txt"
				dial.Filter = "*.txt|*.txt"
				dial.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory & "Scripts\"
				dial.OverwritePrompt = True
				dial.Title = "Save As..."
				dial.ValidateNames = True

				If dial.ShowDialog = DialogResult.OK Then
					mSettingsName = dial.FileName
					mSettings.WriteToFile(mSettingsName)
					Me.lblFile.Text = mSettingsName
				End If
			End Using
		Catch ex As Exception

		End Try
	End Sub

	Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
		Try
			Using dial As New OpenFileDialog
				dial.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory & "Scripts\"
				dial.Filter = "*.txt|*.txt"

				If dial.ShowDialog = DialogResult.OK Then
					mSettingsName = dial.FileName
					mSettings = New ScriptSettings(mSettingsName)
					PopulateControls()
					Me.lblFile.Text = mSettingsName
				End If
			End Using
		Catch ex As Exception

		End Try
	End Sub

	Private Sub SetVariableForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		My.Settings.ScriptPath = mSettingsName
		My.Settings.Save()
	End Sub

	Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
		Dim temp As String = txtScript.Text.Replace(vbCrLf, vbCr)
		Dim Lines As String() = temp.Split(vbCr)

		For Each line As String In Lines
			Select Case line.Split(" ")(0).ToUpper.Trim
				Case "MODERUN"
					LgsWebApi.RunMode()
					Threading.Thread.Sleep(100)
				Case "MODEDESIGN"
					LgsWebApi.DesignMode()
					Threading.Thread.Sleep(100)
				Case "WAIT"
					Dim wait_time As Integer = 0
					Integer.TryParse(line.Trim.Substring(4), wait_time)
					Threading.Thread.Sleep(wait_time)
				Case "SET"
					Dim Name As String = line.Split(" ")(1)
					Dim Value As String = line.Substring(5 + Name.Length)
					LgsWebApi.SetVariable(Name, Value)
					Threading.Thread.Sleep(50)
				Case "RUN"
					Dim Name As String = line.Substring(4).Trim

					If IsNumeric(Name) Then
						LgsWebApi.RunProgram(CInt(Name))
					Else
						LgsWebApi.RunProgram(Name)
					End If

					Threading.Thread.Sleep(250)

				Case "ABORT"
					LgsWebApi.Abort()
					Threading.Thread.Sleep(250)

			End Select




		Next
	End Sub
End Class