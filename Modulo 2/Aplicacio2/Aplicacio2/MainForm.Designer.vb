'
' Creado por SharpDevelop.
' Usuario: Bruce
' Fecha: 09/10/2014
' Hora: 02:02 p.m.
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
		Me.lblAncho = New System.Windows.Forms.Label
		Me.lblLargo = New System.Windows.Forms.Label
		Me.txtAncho = New System.Windows.Forms.TextBox
		Me.txtLargo = New System.Windows.Forms.TextBox
		Me.txtArea = New System.Windows.Forms.TextBox
		Me.btnArea = New System.Windows.Forms.Button
		Me.lblCalculoArea = New System.Windows.Forms.Label
		Me.lblMaKm = New System.Windows.Forms.Label
		Me.lblMillas = New System.Windows.Forms.Label
		Me.txtMillas = New System.Windows.Forms.TextBox
		Me.txtKm = New System.Windows.Forms.TextBox
		Me.btnKm = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'lblAncho
		'
		Me.lblAncho.Location = New System.Drawing.Point(13, 42)
		Me.lblAncho.Name = "lblAncho"
		Me.lblAncho.Size = New System.Drawing.Size(100, 23)
		Me.lblAncho.TabIndex = 0
		Me.lblAncho.Text = "Ancho del terreno"
		'
		'lblLargo
		'
		Me.lblLargo.Location = New System.Drawing.Point(13, 69)
		Me.lblLargo.Name = "lblLargo"
		Me.lblLargo.Size = New System.Drawing.Size(100, 23)
		Me.lblLargo.TabIndex = 1
		Me.lblLargo.Text = "Largo del terreno"
		'
		'txtAncho
		'
		Me.txtAncho.Location = New System.Drawing.Point(120, 42)
		Me.txtAncho.Name = "txtAncho"
		Me.txtAncho.Size = New System.Drawing.Size(115, 20)
		Me.txtAncho.TabIndex = 2
		'
		'txtLargo
		'
		Me.txtLargo.Location = New System.Drawing.Point(120, 69)
		Me.txtLargo.Name = "txtLargo"
		Me.txtLargo.Size = New System.Drawing.Size(115, 20)
		Me.txtLargo.TabIndex = 3
		'
		'txtArea
		'
		Me.txtArea.Location = New System.Drawing.Point(120, 96)
		Me.txtArea.Name = "txtArea"
		Me.txtArea.Size = New System.Drawing.Size(115, 20)
		Me.txtArea.TabIndex = 4
		'
		'btnArea
		'
		Me.btnArea.Location = New System.Drawing.Point(120, 122)
		Me.btnArea.Name = "btnArea"
		Me.btnArea.Size = New System.Drawing.Size(115, 23)
		Me.btnArea.TabIndex = 5
		Me.btnArea.Text = "CALCULAR AREA"
		Me.btnArea.UseVisualStyleBackColor = true
		AddHandler Me.btnArea.Click, AddressOf Me.BtnAreaClick
		'
		'lblCalculoArea
		'
		Me.lblCalculoArea.Location = New System.Drawing.Point(13, 9)
		Me.lblCalculoArea.Name = "lblCalculoArea"
		Me.lblCalculoArea.Size = New System.Drawing.Size(206, 23)
		Me.lblCalculoArea.TabIndex = 6
		Me.lblCalculoArea.Text = "CALCULO DE AREA DE UN TERRENO"
		'
		'lblMaKm
		'
		Me.lblMaKm.Location = New System.Drawing.Point(13, 167)
		Me.lblMaKm.Name = "lblMaKm"
		Me.lblMaKm.Size = New System.Drawing.Size(225, 23)
		Me.lblMaKm.TabIndex = 7
		Me.lblMaKm.Text = "CONVERSION DE MILLAS A KIMOLETROS"
		'
		'lblMillas
		'
		Me.lblMillas.Location = New System.Drawing.Point(13, 194)
		Me.lblMillas.Name = "lblMillas"
		Me.lblMillas.Size = New System.Drawing.Size(100, 23)
		Me.lblMillas.TabIndex = 8
		Me.lblMillas.Text = "Millas a convertir"
		'
		'txtMillas
		'
		Me.txtMillas.Location = New System.Drawing.Point(120, 194)
		Me.txtMillas.Name = "txtMillas"
		Me.txtMillas.Size = New System.Drawing.Size(115, 20)
		Me.txtMillas.TabIndex = 9
		'
		'txtKm
		'
		Me.txtKm.Location = New System.Drawing.Point(120, 221)
		Me.txtKm.Name = "txtKm"
		Me.txtKm.Size = New System.Drawing.Size(115, 20)
		Me.txtKm.TabIndex = 10
		'
		'btnKm
		'
		Me.btnKm.Location = New System.Drawing.Point(120, 248)
		Me.btnKm.Name = "btnKm"
		Me.btnKm.Size = New System.Drawing.Size(115, 23)
		Me.btnKm.TabIndex = 11
		Me.btnKm.Text = "CONVERTIR A Km"
		Me.btnKm.UseVisualStyleBackColor = true
		AddHandler Me.btnKm.Click, AddressOf Me.BtnKmClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 293)
		Me.Controls.Add(Me.btnKm)
		Me.Controls.Add(Me.txtKm)
		Me.Controls.Add(Me.txtMillas)
		Me.Controls.Add(Me.lblMillas)
		Me.Controls.Add(Me.lblMaKm)
		Me.Controls.Add(Me.lblCalculoArea)
		Me.Controls.Add(Me.btnArea)
		Me.Controls.Add(Me.txtArea)
		Me.Controls.Add(Me.txtLargo)
		Me.Controls.Add(Me.txtAncho)
		Me.Controls.Add(Me.lblLargo)
		Me.Controls.Add(Me.lblAncho)
		Me.Name = "MainForm"
		Me.Text = "Aplicacio2"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnKm As System.Windows.Forms.Button
	Private txtKm As System.Windows.Forms.TextBox
	Private txtMillas As System.Windows.Forms.TextBox
	Private lblMillas As System.Windows.Forms.Label
	Private lblMaKm As System.Windows.Forms.Label
	Private lblCalculoArea As System.Windows.Forms.Label
	Private btnArea As System.Windows.Forms.Button
	Private txtArea As System.Windows.Forms.TextBox
	Private txtLargo As System.Windows.Forms.TextBox
	Private txtAncho As System.Windows.Forms.TextBox
	Private lblLargo As System.Windows.Forms.Label
	Private lblAncho As System.Windows.Forms.Label
End Class
