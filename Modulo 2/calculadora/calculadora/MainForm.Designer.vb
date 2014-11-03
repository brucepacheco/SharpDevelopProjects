'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 09/10/2014
' Hora: 03:36 p.m.
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
		Me.txtResultado = New System.Windows.Forms.TextBox
		Me.btn7 = New System.Windows.Forms.Button
		Me.btn8 = New System.Windows.Forms.Button
		Me.btn9 = New System.Windows.Forms.Button
		Me.btn4 = New System.Windows.Forms.Button
		Me.btn5 = New System.Windows.Forms.Button
		Me.btn6 = New System.Windows.Forms.Button
		Me.btn1 = New System.Windows.Forms.Button
		Me.btn2 = New System.Windows.Forms.Button
		Me.btn3 = New System.Windows.Forms.Button
		Me.btn0 = New System.Windows.Forms.Button
		Me.btnC = New System.Windows.Forms.Button
		Me.btnMenos = New System.Windows.Forms.Button
		Me.btnIgual = New System.Windows.Forms.Button
		Me.btnMas = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'txtResultado
		'
		Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtResultado.Location = New System.Drawing.Point(13, 13)
		Me.txtResultado.MaxLength = 9
		Me.txtResultado.Multiline = true
		Me.txtResultado.Name = "txtResultado"
		Me.txtResultado.Size = New System.Drawing.Size(184, 49)
		Me.txtResultado.TabIndex = 0
		Me.txtResultado.Text = "0"
		Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'btn7
		'
		Me.btn7.Location = New System.Drawing.Point(13, 77)
		Me.btn7.Name = "btn7"
		Me.btn7.Size = New System.Drawing.Size(41, 30)
		Me.btn7.TabIndex = 1
		Me.btn7.Text = "7"
		Me.btn7.UseVisualStyleBackColor = true
		AddHandler Me.btn7.Click, AddressOf Me.Btn7Click
		'
		'btn8
		'
		Me.btn8.Location = New System.Drawing.Point(60, 77)
		Me.btn8.Name = "btn8"
		Me.btn8.Size = New System.Drawing.Size(41, 30)
		Me.btn8.TabIndex = 2
		Me.btn8.Text = "8"
		Me.btn8.UseVisualStyleBackColor = true
		AddHandler Me.btn8.Click, AddressOf Me.Btn8Click
		'
		'btn9
		'
		Me.btn9.Location = New System.Drawing.Point(107, 77)
		Me.btn9.Name = "btn9"
		Me.btn9.Size = New System.Drawing.Size(41, 30)
		Me.btn9.TabIndex = 3
		Me.btn9.Text = "9"
		Me.btn9.UseVisualStyleBackColor = true
		AddHandler Me.btn9.Click, AddressOf Me.Btn9Click
		'
		'btn4
		'
		Me.btn4.Location = New System.Drawing.Point(13, 107)
		Me.btn4.Name = "btn4"
		Me.btn4.Size = New System.Drawing.Size(41, 30)
		Me.btn4.TabIndex = 4
		Me.btn4.Text = "4"
		Me.btn4.UseVisualStyleBackColor = true
		AddHandler Me.btn4.Click, AddressOf Me.Btn4Click
		'
		'btn5
		'
		Me.btn5.Location = New System.Drawing.Point(60, 107)
		Me.btn5.Name = "btn5"
		Me.btn5.Size = New System.Drawing.Size(41, 30)
		Me.btn5.TabIndex = 5
		Me.btn5.Text = "5"
		Me.btn5.UseVisualStyleBackColor = true
		AddHandler Me.btn5.Click, AddressOf Me.Btn5Click
		'
		'btn6
		'
		Me.btn6.Location = New System.Drawing.Point(107, 107)
		Me.btn6.Name = "btn6"
		Me.btn6.Size = New System.Drawing.Size(41, 30)
		Me.btn6.TabIndex = 6
		Me.btn6.Text = "6"
		Me.btn6.UseVisualStyleBackColor = true
		AddHandler Me.btn6.Click, AddressOf Me.Btn6Click
		'
		'btn1
		'
		Me.btn1.Location = New System.Drawing.Point(13, 137)
		Me.btn1.Name = "btn1"
		Me.btn1.Size = New System.Drawing.Size(41, 30)
		Me.btn1.TabIndex = 7
		Me.btn1.Text = "1"
		Me.btn1.UseVisualStyleBackColor = true
		AddHandler Me.btn1.Click, AddressOf Me.Btn1Click
		'
		'btn2
		'
		Me.btn2.Location = New System.Drawing.Point(60, 137)
		Me.btn2.Name = "btn2"
		Me.btn2.Size = New System.Drawing.Size(41, 30)
		Me.btn2.TabIndex = 8
		Me.btn2.Text = "2"
		Me.btn2.UseVisualStyleBackColor = true
		AddHandler Me.btn2.Click, AddressOf Me.Btn2Click
		'
		'btn3
		'
		Me.btn3.Location = New System.Drawing.Point(107, 137)
		Me.btn3.Name = "btn3"
		Me.btn3.Size = New System.Drawing.Size(41, 30)
		Me.btn3.TabIndex = 9
		Me.btn3.Text = "3"
		Me.btn3.UseVisualStyleBackColor = true
		AddHandler Me.btn3.Click, AddressOf Me.Btn3Click
		'
		'btn0
		'
		Me.btn0.Location = New System.Drawing.Point(13, 167)
		Me.btn0.Name = "btn0"
		Me.btn0.Size = New System.Drawing.Size(41, 30)
		Me.btn0.TabIndex = 10
		Me.btn0.Text = "0"
		Me.btn0.UseVisualStyleBackColor = true
		AddHandler Me.btn0.Click, AddressOf Me.Btn0Click
		'
		'btnC
		'
		Me.btnC.Location = New System.Drawing.Point(155, 77)
		Me.btnC.Name = "btnC"
		Me.btnC.Size = New System.Drawing.Size(42, 30)
		Me.btnC.TabIndex = 11
		Me.btnC.Text = "C"
		Me.btnC.UseVisualStyleBackColor = true
		AddHandler Me.btnC.Click, AddressOf Me.BtnCClick
		'
		'btnMenos
		'
		Me.btnMenos.Location = New System.Drawing.Point(155, 107)
		Me.btnMenos.Name = "btnMenos"
		Me.btnMenos.Size = New System.Drawing.Size(42, 30)
		Me.btnMenos.TabIndex = 12
		Me.btnMenos.Text = "-"
		Me.btnMenos.UseVisualStyleBackColor = true
		AddHandler Me.btnMenos.Click, AddressOf Me.BtnMenosClick
		'
		'btnIgual
		'
		Me.btnIgual.Location = New System.Drawing.Point(155, 137)
		Me.btnIgual.Name = "btnIgual"
		Me.btnIgual.Size = New System.Drawing.Size(42, 60)
		Me.btnIgual.TabIndex = 13
		Me.btnIgual.Text = "="
		Me.btnIgual.UseVisualStyleBackColor = true
		AddHandler Me.btnIgual.Click, AddressOf Me.BtnIgualClick
		'
		'btnMas
		'
		Me.btnMas.Location = New System.Drawing.Point(60, 167)
		Me.btnMas.Name = "btnMas"
		Me.btnMas.Size = New System.Drawing.Size(88, 30)
		Me.btnMas.TabIndex = 14
		Me.btnMas.Text = "+"
		Me.btnMas.UseVisualStyleBackColor = true
		AddHandler Me.btnMas.Click, AddressOf Me.BtnMasClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(213, 210)
		Me.Controls.Add(Me.btnMas)
		Me.Controls.Add(Me.btnIgual)
		Me.Controls.Add(Me.btnMenos)
		Me.Controls.Add(Me.btnC)
		Me.Controls.Add(Me.btn0)
		Me.Controls.Add(Me.btn3)
		Me.Controls.Add(Me.btn2)
		Me.Controls.Add(Me.btn1)
		Me.Controls.Add(Me.btn6)
		Me.Controls.Add(Me.btn5)
		Me.Controls.Add(Me.btn4)
		Me.Controls.Add(Me.btn9)
		Me.Controls.Add(Me.btn8)
		Me.Controls.Add(Me.btn7)
		Me.Controls.Add(Me.txtResultado)
		Me.Name = "MainForm"
		Me.Text = "calculadora"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnMas As System.Windows.Forms.Button
	Private btnIgual As System.Windows.Forms.Button
	Private btnMenos As System.Windows.Forms.Button
	Private btnC As System.Windows.Forms.Button
	Private btn0 As System.Windows.Forms.Button
	Private btn2 As System.Windows.Forms.Button
	Private btn3 As System.Windows.Forms.Button
	Private btn1 As System.Windows.Forms.Button
	Private btn6 As System.Windows.Forms.Button
	Private btn5 As System.Windows.Forms.Button
	Private btn4 As System.Windows.Forms.Button
	Private btn9 As System.Windows.Forms.Button
	Private btn8 As System.Windows.Forms.Button
	Private btn7 As System.Windows.Forms.Button
	Private txtResultado As System.Windows.Forms.TextBox
End Class
