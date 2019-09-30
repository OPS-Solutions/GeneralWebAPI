<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.btnRunMode = New System.Windows.Forms.Button()
		Me.btnDesignMode = New System.Windows.Forms.Button()
		Me.btnSetVars = New System.Windows.Forms.Button()
		Me.btnScript = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'btnRunMode
		'
		Me.btnRunMode.Location = New System.Drawing.Point(14, 56)
		Me.btnRunMode.Margin = New System.Windows.Forms.Padding(5)
		Me.btnRunMode.Name = "btnRunMode"
		Me.btnRunMode.Size = New System.Drawing.Size(130, 41)
		Me.btnRunMode.TabIndex = 0
		Me.btnRunMode.Text = "Run Mode"
		Me.btnRunMode.UseVisualStyleBackColor = True
		'
		'btnDesignMode
		'
		Me.btnDesignMode.Location = New System.Drawing.Point(14, 14)
		Me.btnDesignMode.Margin = New System.Windows.Forms.Padding(5)
		Me.btnDesignMode.Name = "btnDesignMode"
		Me.btnDesignMode.Size = New System.Drawing.Size(130, 41)
		Me.btnDesignMode.TabIndex = 1
		Me.btnDesignMode.Text = "Design Mode"
		Me.btnDesignMode.UseVisualStyleBackColor = True
		'
		'btnSetVars
		'
		Me.btnSetVars.Location = New System.Drawing.Point(14, 156)
		Me.btnSetVars.Margin = New System.Windows.Forms.Padding(5)
		Me.btnSetVars.Name = "btnSetVars"
		Me.btnSetVars.Size = New System.Drawing.Size(130, 41)
		Me.btnSetVars.TabIndex = 2
		Me.btnSetVars.Text = "Set Variables"
		Me.btnSetVars.UseVisualStyleBackColor = True
		'
		'btnScript
		'
		Me.btnScript.Location = New System.Drawing.Point(14, 207)
		Me.btnScript.Margin = New System.Windows.Forms.Padding(5)
		Me.btnScript.Name = "btnScript"
		Me.btnScript.Size = New System.Drawing.Size(130, 41)
		Me.btnScript.TabIndex = 3
		Me.btnScript.Text = "Script"
		Me.btnScript.UseVisualStyleBackColor = True
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkRed
		Me.ClientSize = New System.Drawing.Size(158, 262)
		Me.Controls.Add(Me.btnScript)
		Me.Controls.Add(Me.btnSetVars)
		Me.Controls.Add(Me.btnDesignMode)
		Me.Controls.Add(Me.btnRunMode)
		Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(5)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "MainForm"
		Me.Text = "LGS API Tester"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnRunMode As Button
	Friend WithEvents btnDesignMode As Button
	Friend WithEvents btnSetVars As Button
	Friend WithEvents btnScript As Button
End Class
