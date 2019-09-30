<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScriptForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScriptForm))
		Me.btnOpen = New System.Windows.Forms.Button()
		Me.lblFile = New System.Windows.Forms.Label()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnRun = New System.Windows.Forms.Button()
		Me.txtScript = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnOpen
		'
		Me.btnOpen.Location = New System.Drawing.Point(8, 33)
		Me.btnOpen.Margin = New System.Windows.Forms.Padding(5)
		Me.btnOpen.Name = "btnOpen"
		Me.btnOpen.Size = New System.Drawing.Size(102, 31)
		Me.btnOpen.TabIndex = 19
		Me.btnOpen.Text = "Open..."
		Me.btnOpen.UseVisualStyleBackColor = True
		'
		'lblFile
		'
		Me.lblFile.AutoSize = True
		Me.lblFile.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFile.Location = New System.Drawing.Point(5, 10)
		Me.lblFile.Name = "lblFile"
		Me.lblFile.Size = New System.Drawing.Size(48, 18)
		Me.lblFile.TabIndex = 18
		Me.lblFile.Text = "Label3"
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(120, 33)
		Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(102, 31)
		Me.btnSave.TabIndex = 17
		Me.btnSave.Text = "Save As..."
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnRun
		'
		Me.btnRun.Location = New System.Drawing.Point(477, 33)
		Me.btnRun.Margin = New System.Windows.Forms.Padding(5)
		Me.btnRun.Name = "btnRun"
		Me.btnRun.Size = New System.Drawing.Size(73, 31)
		Me.btnRun.TabIndex = 11
		Me.btnRun.Text = "Run"
		Me.btnRun.UseVisualStyleBackColor = True
		'
		'txtScript
		'
		Me.txtScript.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtScript.Location = New System.Drawing.Point(0, 71)
		Me.txtScript.Multiline = True
		Me.txtScript.Name = "txtScript"
		Me.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtScript.Size = New System.Drawing.Size(555, 295)
		Me.txtScript.TabIndex = 12
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.btnRun)
		Me.Panel1.Controls.Add(Me.btnSave)
		Me.Panel1.Controls.Add(Me.btnOpen)
		Me.Panel1.Controls.Add(Me.lblFile)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(555, 71)
		Me.Panel1.TabIndex = 20
		'
		'ScriptForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(555, 366)
		Me.Controls.Add(Me.txtScript)
		Me.Controls.Add(Me.Panel1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(5)
		Me.Name = "ScriptForm"
		Me.Text = "ScriptForm"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnOpen As Button
	Friend WithEvents lblFile As Label
	Friend WithEvents btnSave As Button
	Friend WithEvents btnRun As Button
	Friend WithEvents txtScript As TextBox
	Friend WithEvents Panel1 As Panel
End Class
