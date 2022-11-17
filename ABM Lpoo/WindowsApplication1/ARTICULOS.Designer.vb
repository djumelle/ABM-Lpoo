<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARTICULOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBoxArticulos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOtra = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonCalculo = New System.Windows.Forms.Button()
        Me.ButtonContinuar = New System.Windows.Forms.Button()
        Me.NumericUpDownOtra = New System.Windows.Forms.NumericUpDown()
        Me.LabelPrecioEfectivo = New System.Windows.Forms.Label()
        Me.LabelPrecioCuotas = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownOtra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxArticulos
        '
        Me.ComboBoxArticulos.FormattingEnabled = True
        Me.ComboBoxArticulos.Items.AddRange(New Object() {"BLOCK LISO", "BLOCK RAYADO", "CARPETA", "CUADERNO", "LAPICERA", "LAPIZ HB"})
        Me.ComboBoxArticulos.Location = New System.Drawing.Point(20, 36)
        Me.ComboBoxArticulos.Name = "ComboBoxArticulos"
        Me.ComboBoxArticulos.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxArticulos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UNIDADES"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(176, 64)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton6.TabIndex = 2
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Tag = ""
        Me.RadioButton6.Text = "6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(176, 101)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton12.TabIndex = 3
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "12"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButtonOtra
        '
        Me.RadioButtonOtra.AutoSize = True
        Me.RadioButtonOtra.Location = New System.Drawing.Point(176, 145)
        Me.RadioButtonOtra.Name = "RadioButtonOtra"
        Me.RadioButtonOtra.Size = New System.Drawing.Size(55, 17)
        Me.RadioButtonOtra.TabIndex = 4
        Me.RadioButtonOtra.TabStop = True
        Me.RadioButtonOtra.Text = "OTRA"
        Me.RadioButtonOtra.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ARTICULOS"
        '
        'NumericUpDownPrecio
        '
        Me.NumericUpDownPrecio.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownPrecio.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownPrecio.InterceptArrowKeys = False
        Me.NumericUpDownPrecio.Location = New System.Drawing.Point(158, 174)
        Me.NumericUpDownPrecio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDownPrecio.Name = "NumericUpDownPrecio"
        Me.NumericUpDownPrecio.Size = New System.Drawing.Size(110, 23)
        Me.NumericUpDownPrecio.TabIndex = 6
        Me.NumericUpDownPrecio.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "(Ingrese el precio Unitario)"
        '
        'ButtonCalculo
        '
        Me.ButtonCalculo.Location = New System.Drawing.Point(31, 230)
        Me.ButtonCalculo.Name = "ButtonCalculo"
        Me.ButtonCalculo.Size = New System.Drawing.Size(85, 35)
        Me.ButtonCalculo.TabIndex = 8
        Me.ButtonCalculo.Text = "CALCULO"
        Me.ButtonCalculo.UseVisualStyleBackColor = True
        '
        'ButtonContinuar
        '
        Me.ButtonContinuar.Location = New System.Drawing.Point(176, 230)
        Me.ButtonContinuar.Name = "ButtonContinuar"
        Me.ButtonContinuar.Size = New System.Drawing.Size(85, 35)
        Me.ButtonContinuar.TabIndex = 9
        Me.ButtonContinuar.Text = "CONTINUAR"
        Me.ButtonContinuar.UseVisualStyleBackColor = True
        '
        'NumericUpDownOtra
        '
        Me.NumericUpDownOtra.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownOtra.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownOtra.InterceptArrowKeys = False
        Me.NumericUpDownOtra.Location = New System.Drawing.Point(237, 145)
        Me.NumericUpDownOtra.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDownOtra.Name = "NumericUpDownOtra"
        Me.NumericUpDownOtra.Size = New System.Drawing.Size(45, 23)
        Me.NumericUpDownOtra.TabIndex = 10
        Me.NumericUpDownOtra.ThousandsSeparator = True
        Me.NumericUpDownOtra.Visible = False
        '
        'LabelPrecioEfectivo
        '
        Me.LabelPrecioEfectivo.AutoSize = True
        Me.LabelPrecioEfectivo.Location = New System.Drawing.Point(17, 162)
        Me.LabelPrecioEfectivo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPrecioEfectivo.Name = "LabelPrecioEfectivo"
        Me.LabelPrecioEfectivo.Size = New System.Drawing.Size(99, 13)
        Me.LabelPrecioEfectivo.TabIndex = 11
        Me.LabelPrecioEfectivo.Text = "Precio en efectivo: "
        Me.LabelPrecioEfectivo.Visible = False
        '
        'LabelPrecioCuotas
        '
        Me.LabelPrecioCuotas.AutoSize = True
        Me.LabelPrecioCuotas.Location = New System.Drawing.Point(17, 184)
        Me.LabelPrecioCuotas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPrecioCuotas.Name = "LabelPrecioCuotas"
        Me.LabelPrecioCuotas.Size = New System.Drawing.Size(93, 13)
        Me.LabelPrecioCuotas.TabIndex = 12
        Me.LabelPrecioCuotas.Text = "Precio en cuotas: "
        Me.LabelPrecioCuotas.Visible = False
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 305)
        Me.Controls.Add(Me.LabelPrecioCuotas)
        Me.Controls.Add(Me.LabelPrecioEfectivo)
        Me.Controls.Add(Me.NumericUpDownOtra)
        Me.Controls.Add(Me.ButtonContinuar)
        Me.Controls.Add(Me.ButtonCalculo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDownPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButtonOtra)
        Me.Controls.Add(Me.RadioButton12)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxArticulos)
        Me.Name = "Articulos"
        Me.Text = "ARTICULOS"
        CType(Me.NumericUpDownPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownOtra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxArticulos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonOtra As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonCalculo As System.Windows.Forms.Button
    Friend WithEvents ButtonContinuar As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownOtra As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelPrecioEfectivo As Label
    Friend WithEvents LabelPrecioCuotas As Label
End Class
