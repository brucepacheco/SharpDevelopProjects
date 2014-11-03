'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 09/10/2014
' Hora: 01:11 p.m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.lblMAlum = New System.Windows.Forms.Label
		Me.lblNAlum = New System.Windows.Forms.Label
		Me.txtMAlum = New System.Windows.Forms.TextBox
		Me.txtNAlum = New System.Windows.Forms.TextBox
		Me.lblCalificaciones = New System.Windows.Forms.Label
		Me.lblMI = New System.Windows.Forms.Label
		Me.lblMII = New System.Windows.Forms.Label
		Me.lblMIII = New System.Windows.Forms.Label
		Me.txtMI = New System.Windows.Forms.TextBox
		Me.txtMII = New System.Windows.Forms.TextBox
		Me.txtMIII = New System.Windows.Forms.TextBox
		Me.txtPromedio = New System.Windows.Forms.TextBox
		Me.btnPromedio = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'lblMAlum
		'
		Me.lblMAlum.Location = New System.Drawing.Point(13, 13)
		Me.lblMAlum.Name = "lblMAlum"
		Me.lblMAlum.Size = New System.Drawing.Size(108, 23)
		Me.lblMAlum.TabIndex = 0
		Me.lblMAlum.Text = "Matricula del alumno:"
		Me.lblMAlum.UseMnemonic = false
		AddHandler Me.lblMAlum.Click, AddressOf Me.LblMAlumClick
		'
		'lblNAlum
		'
		Me.lblNAlum.Location = New System.Drawing.Point(12, 45)
		Me.lblNAlum.Name = "lblNAlum"
		Me.lblNAlum.Size = New System.Drawing.Size(108, 23)
		Me.lblNAlum.TabIndex = 1
		Me.lblNAlum.Text = "Nombre del alumno:"
		AddHandler Me.lblNAlum.Click, AddressOf Me.Label1Click
		'
		'txtMAlum
		'
		Me.txtMAlum.Location = New System.Drawing.Point(140, 13)
		Me.txtMAlum.Name = "txtMAlum"
		Me.txtMAlum.Size = New System.Drawing.Size(100, 20)
		Me.txtMAlum.TabIndex = 2
		'
		'txtNAlum
		'
		Me.txtNAlum.Location = New System.Drawing.Point(140, 47)
		Me.txtNAlum.Name = "txtNAlum"
		Me.txtNAlum.Size = New System.Drawing.Size(309, 20)
		Me.txtNAlum.TabIndex = 3
		'
		'lblCalificaciones
		'
		Me.lblCalificaciones.Location = New System.Drawing.Point(13, 87)
		Me.lblCalificaciones.Name = "lblCalificaciones"
		Me.lblCalificaciones.Size = New System.Drawing.Size(100, 23)
		Me.lblCalificaciones.TabIndex = 4
		Me.lblCalificaciones.Text = "Calificaciones:"
		'
		'lblMI
		'
		Me.lblMI.Location = New System.Drawing.Point(140, 115)
		Me.lblMI.Name = "lblMI"
		Me.lblMI.Size = New System.Drawing.Size(100, 23)
		Me.lblMI.TabIndex = 5
		Me.lblMI.Text = "Modulo I"
		'
		'lblMII
		'
		Me.lblMII.Location = New System.Drawing.Point(247, 114)
		Me.lblMII.Name = "lblMII"
		Me.lblMII.Size = New System.Drawing.Size(100, 23)
		Me.lblMII.TabIndex = 6
		Me.lblMII.Text = "Modulo II"
		'
		'lblMIII
		'
		Me.lblMIII.Location = New System.Drawing.Point(354, 113)
		Me.lblMIII.Name = "lblMIII"
		Me.lblMIII.Size = New System.Drawing.Size(100, 23)
		Me.lblMIII.TabIndex = 7
		Me.lblMIII.Text = "Modulo III"
		'
		'txtMI
		'
		Me.txtMI.Location = New System.Drawing.Point(140, 131)
		Me.txtMI.Name = "txtMI"
		Me.txtMI.Size = New System.Drawing.Size(100, 20)
		Me.txtMI.TabIndex = 8
		'
		'txtMII
		'
		Me.txtMII.Location = New System.Drawing.Point(247, 130)
		Me.txtMII.Name = "txtMII"
		Me.txtMII.Size = New System.Drawing.Size(100, 20)
		Me.txtMII.TabIndex = 9
		'
		'txtMIII
		'
		Me.txtMIII.Location = New System.Drawing.Point(354, 130)
		Me.txtMIII.Name = "txtMIII"
		Me.txtMIII.Size = New System.Drawing.Size(100, 20)
		Me.txtMIII.TabIndex = 10
		'
		'txtPromedio
		'
		Me.txtPromedio.Location = New System.Drawing.Point(354, 182)
		Me.txtPromedio.Name = "txtPromedio"
		Me.txtPromedio.Size = New System.Drawing.Size(100, 20)
		Me.txtPromedio.TabIndex = 11
		'
		'btnPromedio
		'
		Me.btnPromedio.Location = New System.Drawing.Point(354, 209)
		Me.btnPromedio.Name = "btnPromedio"
		Me.btnPromedio.Size = New System.Drawing.Size(100, 23)
		Me.btnPromedio.TabIndex = 12
		Me.btnPromedio.Text = "PROMEDIO"
		Me.btnPromedio.UseVisualStyleBackColor = true
		AddHandler Me.btnPromedio.Click, AddressOf Me.BtnPromedioClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(500, 262)
		Me.Controls.Add(Me.btnPromedio)
		Me.Controls.Add(Me.txtPromedio)
		Me.Controls.Add(Me.txtMIII)
		Me.Controls.Add(Me.txtMII)
		Me.Controls.Add(Me.txtMI)
		Me.Controls.Add(Me.lblMIII)
		Me.Controls.Add(Me.lblMII)
		Me.Controls.Add(Me.lblMI)
		Me.Controls.Add(Me.lblCalificaciones)
		Me.Controls.Add(Me.txtNAlum)
		Me.Controls.Add(Me.txtMAlum)
		Me.Controls.Add(Me.lblNAlum)
		Me.Controls.Add(Me.lblMAlum)
		Me.Name = "MainForm"
		Me.Text = "Aplicacion1"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnPromedio As System.Windows.Forms.Button
	Private txtPromedio As System.Windows.Forms.TextBox
	Private txtMIII As System.Windows.Forms.TextBox
	Private txtMII As System.Windows.Forms.TextBox
	Private txtMI As System.Windows.Forms.TextBox
	Private lblMIII As System.Windows.Forms.Label
	Private lblMII As System.Windows.Forms.Label
	Private lblMI As System.Windows.Forms.Label
	Private lblCalificaciones As System.Windows.Forms.Label
	Private txtNAlum As System.Windows.Forms.TextBox
	Private txtMAlum As System.Windows.Forms.TextBox
	Private lblNAlum As System.Windows.Forms.Label
	Private lblMAlum As System.Windows.Forms.Label
End Class
