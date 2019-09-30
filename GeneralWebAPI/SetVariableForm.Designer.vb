<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetVariableForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetVariableForm))
		Me.btnSetVariable = New System.Windows.Forms.Button()
		Me.lblSetVariable = New System.Windows.Forms.Label()
		Me.txtSetVariableName = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtSetVariableValue = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.lblFile = New System.Windows.Forms.Label()
		Me.btnOpen = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'btnSetVariable
		'
		Me.btnSetVariable.Location = New System.Drawing.Point(619, 89)
		Me.btnSetVariable.Margin = New System.Windows.Forms.Padding(5)
		Me.btnSetVariable.Name = "btnSetVariable"
		Me.btnSetVariable.Size = New System.Drawing.Size(130, 31)
		Me.btnSetVariable.TabIndex = 2
		Me.btnSetVariable.Text = "Set Variable"
		Me.btnSetVariable.UseVisualStyleBackColor = True
		'
		'lblSetVariable
		'
		Me.lblSetVariable.AutoSize = True
		Me.lblSetVariable.Location = New System.Drawing.Point(3, 92)
		Me.lblSetVariable.Name = "lblSetVariable"
		Me.lblSetVariable.Size = New System.Drawing.Size(20, 23)
		Me.lblSetVariable.TabIndex = 7
		Me.lblSetVariable.Text = "1"
		'
		'txtSetVariableName
		'
		Me.txtSetVariableName.Location = New System.Drawing.Point(29, 89)
		Me.txtSetVariableName.Name = "txtSetVariableName"
		Me.txtSetVariableName.Size = New System.Drawing.Size(205, 31)
		Me.txtSetVariableName.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(236, 63)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 23)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Value"
		'
		'txtSetVariableValue
		'
		Me.txtSetVariableValue.Location = New System.Drawing.Point(240, 89)
		Me.txtSetVariableValue.Multiline = True
		Me.txtSetVariableValue.Name = "txtSetVariableValue"
		Me.txtSetVariableValue.Size = New System.Drawing.Size(371, 31)
		Me.txtSetVariableValue.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(29, 63)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(57, 23)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Name"
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(118, 27)
		Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(102, 31)
		Me.btnSave.TabIndex = 8
		Me.btnSave.Text = "Save As..."
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'lblFile
		'
		Me.lblFile.AutoSize = True
		Me.lblFile.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFile.Location = New System.Drawing.Point(3, 3)
		Me.lblFile.Name = "lblFile"
		Me.lblFile.Size = New System.Drawing.Size(48, 18)
		Me.lblFile.TabIndex = 9
		Me.lblFile.Text = "Label3"
		'
		'btnOpen
		'
		Me.btnOpen.Location = New System.Drawing.Point(6, 27)
		Me.btnOpen.Margin = New System.Windows.Forms.Padding(5)
		Me.btnOpen.Name = "btnOpen"
		Me.btnOpen.Size = New System.Drawing.Size(102, 31)
		Me.btnOpen.TabIndex = 10
		Me.btnOpen.Text = "Open..."
		Me.btnOpen.UseVisualStyleBackColor = True
		'
		'SetVariableForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.ClientSize = New System.Drawing.Size(758, 392)
		Me.Controls.Add(Me.btnOpen)
		Me.Controls.Add(Me.lblFile)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnSetVariable)
		Me.Controls.Add(Me.lblSetVariable)
		Me.Controls.Add(Me.txtSetVariableName)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtSetVariableValue)
		Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(5)
		Me.Name = "SetVariableForm"
		Me.Text = "Set Variables"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnSetVariable As Button
	Friend WithEvents lblSetVariable As Label
	Friend WithEvents txtSetVariableName As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtSetVariableValue As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnSave As Button
	Friend WithEvents lblFile As Label
	Friend WithEvents btnOpen As Button
End Class
