'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 09/10/2014
' Hora: 08:55 a.m.
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
		Me.lblAlumno = New System.Windows.Forms.Label
		Me.lblMateria = New System.Windows.Forms.Label
		Me.lblMatematicas = New System.Windows.Forms.Label
		Me.lblProgramacion = New System.Windows.Forms.Label
		Me.lblBiologia = New System.Windows.Forms.Label
		Me.lblLuis = New System.Windows.Forms.Label
		Me.lblJuan = New System.Windows.Forms.Label
		Me.lblRosa = New System.Windows.Forms.Label
		Me.txtMatLuis = New System.Windows.Forms.TextBox
		Me.txtMatJuan = New System.Windows.Forms.TextBox
		Me.txtMatRosa = New System.Windows.Forms.TextBox
		Me.txtProLuis = New System.Windows.Forms.TextBox
		Me.txtProJuan = New System.Windows.Forms.TextBox
		Me.txtProRosa = New System.Windows.Forms.TextBox
		Me.txtBioLuis = New System.Windows.Forms.TextBox
		Me.txtBioJuan = New System.Windows.Forms.TextBox
		Me.txtBioRosa = New System.Windows.Forms.TextBox
		Me.txtPMat = New System.Windows.Forms.TextBox
		Me.txtPPro = New System.Windows.Forms.TextBox
		Me.txtPBio = New System.Windows.Forms.TextBox
		Me.btnPxm = New System.Windows.Forms.Button
		Me.txtPLuis = New System.Windows.Forms.TextBox
		Me.txtPJuan = New System.Windows.Forms.TextBox
		Me.txtPRosa = New System.Windows.Forms.TextBox
		Me.btnPxa = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'lblAlumno
		'
		Me.lblAlumno.Location = New System.Drawing.Point(42, 13)
		Me.lblAlumno.Name = "lblAlumno"
		Me.lblAlumno.Size = New System.Drawing.Size(62, 23)
		Me.lblAlumno.TabIndex = 0
		Me.lblAlumno.Text = "Alumno"
		AddHandler Me.lblAlumno.Click, AddressOf Me.Label1Click
		'
		'lblMateria
		'
		Me.lblMateria.Location = New System.Drawing.Point(13, 52)
		Me.lblMateria.Name = "lblMateria"
		Me.lblMateria.Size = New System.Drawing.Size(100, 23)
		Me.lblMateria.TabIndex = 0
		Me.lblMateria.Text = "Materia"
		'
		'lblMatematicas
		'
		Me.lblMatematicas.Location = New System.Drawing.Point(13, 79)
		Me.lblMatematicas.Name = "lblMatematicas"
		Me.lblMatematicas.Size = New System.Drawing.Size(100, 23)
		Me.lblMatematicas.TabIndex = 0
		Me.lblMatematicas.Text = "Matematicas"
		AddHandler Me.lblMatematicas.Click, AddressOf Me.Label1Click
		'
		'lblProgramacion
		'
		Me.lblProgramacion.Location = New System.Drawing.Point(13, 106)
		Me.lblProgramacion.Name = "lblProgramacion"
		Me.lblProgramacion.Size = New System.Drawing.Size(100, 23)
		Me.lblProgramacion.TabIndex = 0
		Me.lblProgramacion.Text = "Programación"
		'
		'lblBiologia
		'
		Me.lblBiologia.Location = New System.Drawing.Point(13, 133)
		Me.lblBiologia.Name = "lblBiologia"
		Me.lblBiologia.Size = New System.Drawing.Size(100, 23)
		Me.lblBiologia.TabIndex = 0
		Me.lblBiologia.Text = "Biologia"
		'
		'lblLuis
		'
		Me.lblLuis.Location = New System.Drawing.Point(110, 13)
		Me.lblLuis.Name = "lblLuis"
		Me.lblLuis.Size = New System.Drawing.Size(100, 23)
		Me.lblLuis.TabIndex = 0
		Me.lblLuis.Text = "Luis"
		AddHandler Me.lblLuis.Click, AddressOf Me.Label1Click
		'
		'lblJuan
		'
		Me.lblJuan.Location = New System.Drawing.Point(231, 13)
		Me.lblJuan.Name = "lblJuan"
		Me.lblJuan.Size = New System.Drawing.Size(100, 23)
		Me.lblJuan.TabIndex = 0
		Me.lblJuan.Text = "Juan"
		'
		'lblRosa
		'
		Me.lblRosa.Location = New System.Drawing.Point(353, 13)
		Me.lblRosa.Name = "lblRosa"
		Me.lblRosa.Size = New System.Drawing.Size(100, 23)
		Me.lblRosa.TabIndex = 0
		Me.lblRosa.Text = "Rosa"
		AddHandler Me.lblRosa.Click, AddressOf Me.Label1Click
		'
		'txtMatLuis
		'
		Me.txtMatLuis.Location = New System.Drawing.Point(110, 76)
		Me.txtMatLuis.Name = "txtMatLuis"
		Me.txtMatLuis.Size = New System.Drawing.Size(100, 20)
		Me.txtMatLuis.TabIndex = 1
		'
		'txtMatJuan
		'
		Me.txtMatJuan.Location = New System.Drawing.Point(231, 76)
		Me.txtMatJuan.Name = "txtMatJuan"
		Me.txtMatJuan.Size = New System.Drawing.Size(100, 20)
		Me.txtMatJuan.TabIndex = 4
		'
		'txtMatRosa
		'
		Me.txtMatRosa.Location = New System.Drawing.Point(353, 76)
		Me.txtMatRosa.Name = "txtMatRosa"
		Me.txtMatRosa.Size = New System.Drawing.Size(100, 20)
		Me.txtMatRosa.TabIndex = 7
		'
		'txtProLuis
		'
		Me.txtProLuis.Location = New System.Drawing.Point(110, 108)
		Me.txtProLuis.Name = "txtProLuis"
		Me.txtProLuis.Size = New System.Drawing.Size(100, 20)
		Me.txtProLuis.TabIndex = 2
		'
		'txtProJuan
		'
		Me.txtProJuan.Location = New System.Drawing.Point(231, 108)
		Me.txtProJuan.Name = "txtProJuan"
		Me.txtProJuan.Size = New System.Drawing.Size(100, 20)
		Me.txtProJuan.TabIndex = 5
		'
		'txtProRosa
		'
		Me.txtProRosa.Location = New System.Drawing.Point(353, 106)
		Me.txtProRosa.Name = "txtProRosa"
		Me.txtProRosa.Size = New System.Drawing.Size(100, 20)
		Me.txtProRosa.TabIndex = 8
		'
		'txtBioLuis
		'
		Me.txtBioLuis.Location = New System.Drawing.Point(110, 135)
		Me.txtBioLuis.Name = "txtBioLuis"
		Me.txtBioLuis.Size = New System.Drawing.Size(100, 20)
		Me.txtBioLuis.TabIndex = 3
		'
		'txtBioJuan
		'
		Me.txtBioJuan.Location = New System.Drawing.Point(231, 135)
		Me.txtBioJuan.Name = "txtBioJuan"
		Me.txtBioJuan.Size = New System.Drawing.Size(100, 20)
		Me.txtBioJuan.TabIndex = 6
		'
		'txtBioRosa
		'
		Me.txtBioRosa.Location = New System.Drawing.Point(353, 133)
		Me.txtBioRosa.Name = "txtBioRosa"
		Me.txtBioRosa.Size = New System.Drawing.Size(100, 20)
		Me.txtBioRosa.TabIndex = 9
		'
		'txtPMat
		'
		Me.txtPMat.Location = New System.Drawing.Point(475, 76)
		Me.txtPMat.Name = "txtPMat"
		Me.txtPMat.Size = New System.Drawing.Size(100, 20)
		Me.txtPMat.TabIndex = 0
		'
		'txtPPro
		'
		Me.txtPPro.Location = New System.Drawing.Point(475, 106)
		Me.txtPPro.Name = "txtPPro"
		Me.txtPPro.Size = New System.Drawing.Size(100, 20)
		Me.txtPPro.TabIndex = 0
		'
		'txtPBio
		'
		Me.txtPBio.Location = New System.Drawing.Point(475, 135)
		Me.txtPBio.Name = "txtPBio"
		Me.txtPBio.Size = New System.Drawing.Size(100, 20)
		Me.txtPBio.TabIndex = 0
		'
		'btnPxm
		'
		Me.btnPxm.Location = New System.Drawing.Point(489, 13)
		Me.btnPxm.Name = "btnPxm"
		Me.btnPxm.Size = New System.Drawing.Size(75, 43)
		Me.btnPxm.TabIndex = 10
		Me.btnPxm.Text = "Promedio x materia"
		Me.btnPxm.UseVisualStyleBackColor = true
		AddHandler Me.btnPxm.Click, AddressOf Me.BtnPxmClick
		'
		'txtPLuis
		'
		Me.txtPLuis.Location = New System.Drawing.Point(110, 185)
		Me.txtPLuis.Name = "txtPLuis"
		Me.txtPLuis.Size = New System.Drawing.Size(100, 20)
		Me.txtPLuis.TabIndex = 0
		'
		'txtPJuan
		'
		Me.txtPJuan.Location = New System.Drawing.Point(231, 185)
		Me.txtPJuan.Name = "txtPJuan"
		Me.txtPJuan.Size = New System.Drawing.Size(100, 20)
		Me.txtPJuan.TabIndex = 0
		'
		'txtPRosa
		'
		Me.txtPRosa.Location = New System.Drawing.Point(353, 185)
		Me.txtPRosa.Name = "txtPRosa"
		Me.txtPRosa.Size = New System.Drawing.Size(100, 20)
		Me.txtPRosa.TabIndex = 0
		'
		'btnPxa
		'
		Me.btnPxa.Location = New System.Drawing.Point(13, 185)
		Me.btnPxa.Name = "btnPxa"
		Me.btnPxa.Size = New System.Drawing.Size(75, 37)
		Me.btnPxa.TabIndex = 11
		Me.btnPxa.Text = "Promedio x alumno"
		Me.btnPxa.UseVisualStyleBackColor = true
		AddHandler Me.btnPxa.Click, AddressOf Me.BtnPxaClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(604, 262)
		Me.Controls.Add(Me.btnPxa)
		Me.Controls.Add(Me.txtPRosa)
		Me.Controls.Add(Me.txtPJuan)
		Me.Controls.Add(Me.txtPLuis)
		Me.Controls.Add(Me.btnPxm)
		Me.Controls.Add(Me.txtPBio)
		Me.Controls.Add(Me.txtPPro)
		Me.Controls.Add(Me.txtPMat)
		Me.Controls.Add(Me.txtBioRosa)
		Me.Controls.Add(Me.txtBioJuan)
		Me.Controls.Add(Me.txtBioLuis)
		Me.Controls.Add(Me.txtProRosa)
		Me.Controls.Add(Me.txtProJuan)
		Me.Controls.Add(Me.txtProLuis)
		Me.Controls.Add(Me.txtMatRosa)
		Me.Controls.Add(Me.txtMatJuan)
		Me.Controls.Add(Me.txtMatLuis)
		Me.Controls.Add(Me.lblRosa)
		Me.Controls.Add(Me.lblJuan)
		Me.Controls.Add(Me.lblLuis)
		Me.Controls.Add(Me.lblBiologia)
		Me.Controls.Add(Me.lblProgramacion)
		Me.Controls.Add(Me.lblMatematicas)
		Me.Controls.Add(Me.lblMateria)
		Me.Controls.Add(Me.lblAlumno)
		Me.Name = "MainForm"
		Me.Text = "frmAplicación1"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtPMat As System.Windows.Forms.TextBox
	Private txtPPro As System.Windows.Forms.TextBox
	Private txtPBio As System.Windows.Forms.TextBox
	Private btnPxa As System.Windows.Forms.Button
	Private txtPRosa As System.Windows.Forms.TextBox
	Private txtPJuan As System.Windows.Forms.TextBox
	Private txtPLuis As System.Windows.Forms.TextBox
	Private btnPxm As System.Windows.Forms.Button
	Private lblRosa As System.Windows.Forms.Label
	Private txtBioRosa As System.Windows.Forms.TextBox
	Private txtBioJuan As System.Windows.Forms.TextBox
	Private txtBioLuis As System.Windows.Forms.TextBox
	Private txtProRosa As System.Windows.Forms.TextBox
	Private txtProJuan As System.Windows.Forms.TextBox
	Private txtProLuis As System.Windows.Forms.TextBox
	Private txtMatRosa As System.Windows.Forms.TextBox
	Private txtMatJuan As System.Windows.Forms.TextBox
	Private txtMatLuis As System.Windows.Forms.TextBox
	Private lblLuis As System.Windows.Forms.Label
	Private lblJuan As System.Windows.Forms.Label
	Private lblMatematicas As System.Windows.Forms.Label
	Private lblBiologia As System.Windows.Forms.Label
	Private lblProgramacion As System.Windows.Forms.Label
	Private lblAlumno As System.Windows.Forms.Label
	Private lblMateria As System.Windows.Forms.Label
End Class
