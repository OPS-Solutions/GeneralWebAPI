Public Class SetVariableForm
	Dim mSettingsName As String
	Dim mSettings As SetVariableSettings

	Private Sub SetVariableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		mSettingsName = My.Settings.SetVariablePath

		If String.IsNullOrWhiteSpace(mSettingsName) Then
			mSettingsName = AppDomain.CurrentDomain.BaseDirectory & "SetVariable\Default Set Variable Settings.xml"
		End If

		mSettings = New SetVariableSettings(mSettingsName)
		PopulateControls()

		Me.txtSetVariableName.Hide()
		Me.txtSetVariableValue.Hide()
		Me.btnSetVariable.Hide()
		Me.lblSetVariable.Hide()

		Me.lblFile.Text = mSettingsName
	End Sub
	Private Sub PopulateControls()
		EliminateControls()

		For i As Integer = 0 To mSettings.Variables.Count - 1
			CreateLabel(i)
			CreateNameTextBox(i, mSettings.Variables(i).Name)
			CreateValueTextBox(i, mSettings.Variables(i).Value)
			CreateButton(i)
		Next
	End Sub
	Private Sub EliminateControls()
		Me.SuspendLayout()

		For i As Integer = Me.Controls.Count - 1 To 0 Step -1

			Dim con As Control = Me.Controls(i)
			Select Case con.Name
				Case txtSetVariableName.Name, txtSetVariableValue.Name, lblFile.Name, lblSetVariable.Name, btnOpen.Name, btnSave.Name, btnSetVariable.Name

				Case Else
					con.Hide()
					con.Dispose()
			End Select
		Next
		'Threading.Thread.Sleep(500)
		Me.ResumeLayout()
		Me.Refresh()
		Me.Update()
	End Sub
	Private Const ROW_HEIGHT As Integer = 29

	Private Sub CreateLabel(ByVal i As Integer)
		Dim lbl As New Label

		With lbl
			.Name = $"lblSetVariable{i.ToString}"
			.Height = Me.lblSetVariable.Height
			.Width = Me.lblSetVariable.Width
			.Location = New System.Drawing.Point(Me.lblSetVariable.Location.X, Me.lblSetVariable.Location.Y + (i * ROW_HEIGHT))
			.Text = (i + 1).ToString
		End With

		Me.Controls.Add(lbl)
	End Sub

	Private Sub CreateNameTextBox(ByVal i As Integer, ByVal text As String)
		Dim txt As New TextBox

		With txt
			.Name = $"txtSetVariableName{i.ToString}"
			.Height = Me.txtSetVariableName.Height
			.Width = Me.txtSetVariableName.Width
			.Location = New System.Drawing.Point(Me.txtSetVariableName.Location.X, Me.txtSetVariableName.Location.Y + (i * ROW_HEIGHT))
			.Text = text
		End With

		Me.Controls.Add(txt)
	End Sub
	Private Sub CreateValueTextBox(ByVal i As Integer, ByVal text As String)
		Dim txt As New TextBox

		With txt
			.Name = $"txtSetVariableValue{i.ToString}"
			.Height = Me.txtSetVariableValue.Height
			.Width = Me.txtSetVariableValue.Width
			.Location = New System.Drawing.Point(Me.txtSetVariableValue.Location.X, Me.txtSetVariableValue.Location.Y + (i * ROW_HEIGHT))
			.Multiline = True
			.Text = text
		End With

		Me.Controls.Add(txt)
	End Sub
	Private Sub CreateButton(ByVal i As Integer)
		Dim txt As New Button

		With txt
			.Name = $"btnSetVariable{i.ToString}"
			.Height = Me.btnSetVariable.Height
			.Width = Me.btnSetVariable.Width
			.Location = New System.Drawing.Point(Me.btnSetVariable.Location.X, Me.btnSetVariable.Location.Y + (i * ROW_HEIGHT))
			.Text = "Set"
		End With

		Me.Controls.Add(txt)
		AddHandler txt.Click, AddressOf Me.SetVariableButtonEventHandler
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
			For i As Integer = 0 To mSettings.Variables.Count - 1
				Dim txtName As TextBox = Controls("txtSetVariableName" & i.ToString)
				Dim txtValue As TextBox = Controls("txtSetVariableValue" & i.ToString)

				mSettings.Variables(i).Name = txtName.Text
				mSettings.Variables(i).Value = txtValue.Text
			Next


			Using dial As New SaveFileDialog
				dial.AddExtension = True
				dial.CreatePrompt = False
				dial.DefaultExt = ".xml"
				dial.Filter = "*.xml|*.xml"
				dial.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory & "SetVariable\"
				dial.OverwritePrompt = True
				dial.Title = "Save As..."
				dial.ValidateNames = True

				If dial.ShowDialog = DialogResult.OK Then
					mSettingsName = dial.FileName
					mSettings.WriteToXml(mSettingsName)
					Me.lblFile.Text = mSettingsName
				End If
			End Using
		Catch ex As Exception

		End Try
	End Sub

	Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
		Try
			Using dial As New OpenFileDialog
				dial.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory & "SetVariable\"
				dial.Filter = "*.xml|*.xml"

				If dial.ShowDialog = DialogResult.OK Then
					mSettingsName = dial.FileName
					mSettings = New SetVariableSettings(mSettingsName)
					PopulateControls()
					Me.lblFile.Text = mSettingsName
				End If
			End Using
		Catch ex As Exception

		End Try
	End Sub

	Private Sub SetVariableForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		My.Settings.SetVariablePath = mSettingsName
		My.Settings.Save()
	End Sub
End Class