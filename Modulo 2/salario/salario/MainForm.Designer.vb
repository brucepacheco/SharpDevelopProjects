'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 27/10/2014
' Hora: 11:43 p.m.
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
		Me.lblCurp = New System.Windows.Forms.Label
		Me.txtCurp = New System.Windows.Forms.TextBox
		Me.lblNombre = New System.Windows.Forms.Label
		Me.txtNombre = New System.Windows.Forms.TextBox
		Me.lblSexo = New System.Windows.Forms.Label
		Me.lblEdad = New System.Windows.Forms.Label
		Me.txtSexo = New System.Windows.Forms.TextBox
		Me.txtEdad = New System.Windows.Forms.TextBox
		Me.lblEstado = New System.Windows.Forms.Label
		Me.txtEstado = New System.Windows.Forms.TextBox
		Me.lblTelefono = New System.Windows.Forms.Label
		Me.txtTelefono = New System.Windows.Forms.TextBox
		Me.lblEstados = New System.Windows.Forms.Label
		Me.ldlEstados1 = New System.Windows.Forms.Label
		Me.lblEstados2 = New System.Windows.Forms.Label
		Me.lblEstados3 = New System.Windows.Forms.Label
		Me.lblSalario = New System.Windows.Forms.Label
		Me.txtSalario = New System.Windows.Forms.TextBox
		Me.btnCalcular = New System.Windows.Forms.Button
		Me.lblZona0 = New System.Windows.Forms.Label
		Me.lblZona1 = New System.Windows.Forms.Label
		Me.lblZona2 = New System.Windows.Forms.Label
		Me.SuspendLayout
		'
		'lblCurp
		'
		Me.lblCurp.Location = New System.Drawing.Point(13, 13)
		Me.lblCurp.Name = "lblCurp"
		Me.lblCurp.Size = New System.Drawing.Size(100, 23)
		Me.lblCurp.TabIndex = 0
		Me.lblCurp.Text = "CURP:"
		'
		'txtCurp
		'
		Me.txtCurp.Location = New System.Drawing.Point(90, 10)
		Me.txtCurp.Name = "txtCurp"
		Me.txtCurp.Size = New System.Drawing.Size(161, 20)
		Me.txtCurp.TabIndex = 1
		'
		'lblNombre
		'
		Me.lblNombre.Location = New System.Drawing.Point(274, 13)
		Me.lblNombre.Name = "lblNombre"
		Me.lblNombre.Size = New System.Drawing.Size(100, 23)
		Me.lblNombre.TabIndex = 2
		Me.lblNombre.Text = "Nombre:"
		'
		'txtNombre
		'
		Me.txtNombre.Location = New System.Drawing.Point(351, 10)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(161, 20)
		Me.txtNombre.TabIndex = 3
		'
		'lblSexo
		'
		Me.lblSexo.Location = New System.Drawing.Point(14, 42)
		Me.lblSexo.Name = "lblSexo"
		Me.lblSexo.Size = New System.Drawing.Size(100, 23)
		Me.lblSexo.TabIndex = 4
		Me.lblSexo.Text = "Sexo:"
		AddHandler Me.lblSexo.Click, AddressOf Me.Label1Click
		'
		'lblEdad
		'
		Me.lblEdad.Location = New System.Drawing.Point(274, 42)
		Me.lblEdad.Name = "lblEdad"
		Me.lblEdad.Size = New System.Drawing.Size(100, 23)
		Me.lblEdad.TabIndex = 5
		Me.lblEdad.Text = "Edad:"
		'
		'txtSexo
		'
		Me.txtSexo.Location = New System.Drawing.Point(91, 39)
		Me.txtSexo.Name = "txtSexo"
		Me.txtSexo.Size = New System.Drawing.Size(161, 20)
		Me.txtSexo.TabIndex = 6
		'
		'txtEdad
		'
		Me.txtEdad.Location = New System.Drawing.Point(351, 39)
		Me.txtEdad.Name = "txtEdad"
		Me.txtEdad.Size = New System.Drawing.Size(161, 20)
		Me.txtEdad.TabIndex = 7
		'
		'lblEstado
		'
		Me.lblEstado.Location = New System.Drawing.Point(14, 106)
		Me.lblEstado.Name = "lblEstado"
		Me.lblEstado.Size = New System.Drawing.Size(100, 23)
		Me.lblEstado.TabIndex = 8
		Me.lblEstado.Text = "Estado:"
		'
		'txtEstado
		'
		Me.txtEstado.Location = New System.Drawing.Point(92, 103)
		Me.txtEstado.Name = "txtEstado"
		Me.txtEstado.Size = New System.Drawing.Size(161, 20)
		Me.txtEstado.TabIndex = 9
		Me.txtEstado.Text = "0"
		'
		'lblTelefono
		'
		Me.lblTelefono.Location = New System.Drawing.Point(14, 75)
		Me.lblTelefono.Name = "lblTelefono"
		Me.lblTelefono.Size = New System.Drawing.Size(100, 23)
		Me.lblTelefono.TabIndex = 10
		Me.lblTelefono.Text = "Telefono:"
		'
		'txtTelefono
		'
		Me.txtTelefono.Location = New System.Drawing.Point(92, 72)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(161, 20)
		Me.txtTelefono.TabIndex = 11
		'
		'lblEstados
		'
		Me.lblEstados.Location = New System.Drawing.Point(89, 129)
		Me.lblEstados.Name = "lblEstados"
		Me.lblEstados.Size = New System.Drawing.Size(162, 33)
		Me.lblEstados.TabIndex = 12
		Me.lblEstados.Text = "Escriba el numero de zona en la que se encuentra el trabajador:"
		'
		'ldlEstados1
		'
		Me.ldlEstados1.Location = New System.Drawing.Point(89, 180)
		Me.ldlEstados1.Name = "ldlEstados1"
		Me.ldlEstados1.Size = New System.Drawing.Size(125, 33)
		Me.ldlEstados1.TabIndex = 13
		Me.ldlEstados1.Text = "México, Puebla, Monterrey, Jalisco"
		'
		'lblEstados2
		'
		Me.lblEstados2.Location = New System.Drawing.Point(89, 227)
		Me.lblEstados2.Name = "lblEstados2"
		Me.lblEstados2.Size = New System.Drawing.Size(147, 23)
		Me.lblEstados2.TabIndex = 14
		Me.lblEstados2.Text = "Veracruz, Tamaulipas"
		'
		'lblEstados3
		'
		Me.lblEstados3.Location = New System.Drawing.Point(89, 263)
		Me.lblEstados3.Name = "lblEstados3"
		Me.lblEstados3.Size = New System.Drawing.Size(147, 23)
		Me.lblEstados3.TabIndex = 15
		Me.lblEstados3.Text = "Cualquier otro estado"
		'
		'lblSalario
		'
		Me.lblSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblSalario.Location = New System.Drawing.Point(274, 166)
		Me.lblSalario.Name = "lblSalario"
		Me.lblSalario.Size = New System.Drawing.Size(283, 23)
		Me.lblSalario.TabIndex = 16
		Me.lblSalario.Text = "El salario del trabajador es:"
		'
		'txtSalario
		'
		Me.txtSalario.Location = New System.Drawing.Point(274, 193)
		Me.txtSalario.Name = "txtSalario"
		Me.txtSalario.Size = New System.Drawing.Size(283, 20)
		Me.txtSalario.TabIndex = 17
		AddHandler Me.txtSalario.TextChanged, AddressOf Me.TxtSalarioTextChanged
		'
		'btnCalcular
		'
		Me.btnCalcular.Location = New System.Drawing.Point(274, 222)
		Me.btnCalcular.Name = "btnCalcular"
		Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
		Me.btnCalcular.TabIndex = 18
		Me.btnCalcular.Text = "Calcular"
		Me.btnCalcular.UseVisualStyleBackColor = true
		AddHandler Me.btnCalcular.Click, AddressOf Me.BtnCalcularClick
		'
		'lblZona0
		'
		Me.lblZona0.Location = New System.Drawing.Point(89, 166)
		Me.lblZona0.Name = "lblZona0"
		Me.lblZona0.Size = New System.Drawing.Size(100, 14)
		Me.lblZona0.TabIndex = 19
		Me.lblZona0.Text = "Zona 0"
		'
		'lblZona1
		'
		Me.lblZona1.Location = New System.Drawing.Point(89, 213)
		Me.lblZona1.Name = "lblZona1"
		Me.lblZona1.Size = New System.Drawing.Size(100, 14)
		Me.lblZona1.TabIndex = 20
		Me.lblZona1.Text = "Zona 1"
		'
		'lblZona2
		'
		Me.lblZona2.Location = New System.Drawing.Point(89, 250)
		Me.lblZona2.Name = "lblZona2"
		Me.lblZona2.Size = New System.Drawing.Size(100, 14)
		Me.lblZona2.TabIndex = 21
		Me.lblZona2.Text = "Zona 2"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(569, 363)
		Me.Controls.Add(Me.lblZona2)
		Me.Controls.Add(Me.lblZona1)
		Me.Controls.Add(Me.lblZona0)
		Me.Controls.Add(Me.btnCalcular)
		Me.Controls.Add(Me.txtSalario)
		Me.Controls.Add(Me.lblSalario)
		Me.Controls.Add(Me.lblEstados3)
		Me.Controls.Add(Me.lblEstados2)
		Me.Controls.Add(Me.ldlEstados1)
		Me.Controls.Add(Me.lblEstados)
		Me.Controls.Add(Me.txtTelefono)
		Me.Controls.Add(Me.lblTelefono)
		Me.Controls.Add(Me.txtEstado)
		Me.Controls.Add(Me.lblEstado)
		Me.Controls.Add(Me.txtEdad)
		Me.Controls.Add(Me.txtSexo)
		Me.Controls.Add(Me.lblEdad)
		Me.Controls.Add(Me.lblSexo)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.lblNombre)
		Me.Controls.Add(Me.txtCurp)
		Me.Controls.Add(Me.lblCurp)
		Me.Name = "MainForm"
		Me.Text = "salario"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lblZona2 As System.Windows.Forms.Label
	Private lblZona1 As System.Windows.Forms.Label
	Private lblZona0 As System.Windows.Forms.Label
	Private btnCalcular As System.Windows.Forms.Button
	Private txtSalario As System.Windows.Forms.TextBox
	Private lblSalario As System.Windows.Forms.Label
	Private lblEstados3 As System.Windows.Forms.Label
	Private lblEstados2 As System.Windows.Forms.Label
	Private ldlEstados1 As System.Windows.Forms.Label
	Private lblEstados As System.Windows.Forms.Label
	Private txtTelefono As System.Windows.Forms.TextBox
	Private lblTelefono As System.Windows.Forms.Label
	Private txtEstado As System.Windows.Forms.TextBox
	Private lblEstado As System.Windows.Forms.Label
	Private txtEdad As System.Windows.Forms.TextBox
	Private txtSexo As System.Windows.Forms.TextBox
	Private txtCurp As System.Windows.Forms.TextBox
	Private txtNombre As System.Windows.Forms.TextBox
	Private lblSexo As System.Windows.Forms.Label
	Private lblEdad As System.Windows.Forms.Label
	Private lblNombre As System.Windows.Forms.Label
	Private lblCurp As System.Windows.Forms.Label
End Class
