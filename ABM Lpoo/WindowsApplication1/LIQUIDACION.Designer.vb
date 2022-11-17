<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LIQUIDACION
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelNombreCliente = New System.Windows.Forms.Label()
        Me.LabelNombreArticulo = New System.Windows.Forms.Label()
        Me.LabelCantYPrecio = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.ButtonVerListas = New System.Windows.Forms.Button()
        Me.TextBoxNombreCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreArticulo = New System.Windows.Forms.TextBox()
        Me.TextBoxCantYPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelNombreCliente
        '
        Me.LabelNombreCliente.AutoSize = True
        Me.LabelNombreCliente.Location = New System.Drawing.Point(120, 17)
        Me.LabelNombreCliente.Name = "LabelNombreCliente"
        Me.LabelNombreCliente.Size = New System.Drawing.Size(95, 13)
        Me.LabelNombreCliente.TabIndex = 0
        Me.LabelNombreCliente.Text = "Nombre del cliente"
        '
        'LabelNombreArticulo
        '
        Me.LabelNombreArticulo.AutoSize = True
        Me.LabelNombreArticulo.Location = New System.Drawing.Point(117, 69)
        Me.LabelNombreArticulo.Name = "LabelNombreArticulo"
        Me.LabelNombreArticulo.Size = New System.Drawing.Size(98, 13)
        Me.LabelNombreArticulo.TabIndex = 1
        Me.LabelNombreArticulo.Text = "Nombre del articulo"
        '
        'LabelCantYPrecio
        '
        Me.LabelCantYPrecio.AutoSize = True
        Me.LabelCantYPrecio.Location = New System.Drawing.Point(104, 127)
        Me.LabelCantYPrecio.Name = "LabelCantYPrecio"
        Me.LabelCantYPrecio.Size = New System.Drawing.Size(126, 13)
        Me.LabelCantYPrecio.TabIndex = 2
        Me.LabelCantYPrecio.Text = "Cantidad y precio unitario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(129, 182)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(76, 13)
        Me.LabelTotal.TabIndex = 3
        Me.LabelTotal.Text = "Total a abonar"
        '
        'ButtonVerListas
        '
        Me.ButtonVerListas.Location = New System.Drawing.Point(120, 214)
        Me.ButtonVerListas.Name = "ButtonVerListas"
        Me.ButtonVerListas.Size = New System.Drawing.Size(85, 35)
        Me.ButtonVerListas.TabIndex = 9
        Me.ButtonVerListas.Text = "VER LAS LISTAS"
        Me.ButtonVerListas.UseVisualStyleBackColor = True
        '
        'TextBoxNombreCliente
        '
        Me.TextBoxNombreCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNombreCliente.Enabled = False
        Me.TextBoxNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombreCliente.Location = New System.Drawing.Point(91, 32)
        Me.TextBoxNombreCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxNombreCliente.Name = "TextBoxNombreCliente"
        Me.TextBoxNombreCliente.ReadOnly = True
        Me.TextBoxNombreCliente.Size = New System.Drawing.Size(97, 12)
        Me.TextBoxNombreCliente.TabIndex = 10
        '
        'TextBoxNombreArticulo
        '
        Me.TextBoxNombreArticulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxNombreArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNombreArticulo.Enabled = False
        Me.TextBoxNombreArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombreArticulo.Location = New System.Drawing.Point(91, 84)
        Me.TextBoxNombreArticulo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxNombreArticulo.Name = "TextBoxNombreArticulo"
        Me.TextBoxNombreArticulo.ReadOnly = True
        Me.TextBoxNombreArticulo.Size = New System.Drawing.Size(97, 12)
        Me.TextBoxNombreArticulo.TabIndex = 11
        '
        'TextBoxCantYPrecio
        '
        Me.TextBoxCantYPrecio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxCantYPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCantYPrecio.Enabled = False
        Me.TextBoxCantYPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCantYPrecio.Location = New System.Drawing.Point(91, 142)
        Me.TextBoxCantYPrecio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxCantYPrecio.Name = "TextBoxCantYPrecio"
        Me.TextBoxCantYPrecio.ReadOnly = True
        Me.TextBoxCantYPrecio.Size = New System.Drawing.Size(97, 12)
        Me.TextBoxCantYPrecio.TabIndex = 12
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTotal.Enabled = False
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(91, 197)
        Me.TextBoxTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(97, 12)
        Me.TextBoxTotal.TabIndex = 13
        '
        'Liquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(316, 274)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.TextBoxCantYPrecio)
        Me.Controls.Add(Me.TextBoxNombreArticulo)
        Me.Controls.Add(Me.TextBoxNombreCliente)
        Me.Controls.Add(Me.ButtonVerListas)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelCantYPrecio)
        Me.Controls.Add(Me.LabelNombreArticulo)
        Me.Controls.Add(Me.LabelNombreCliente)
        Me.Name = "Liquidacion"
        Me.Text = "LIQUIDACION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelNombreCliente As System.Windows.Forms.Label
    Friend WithEvents LabelNombreArticulo As System.Windows.Forms.Label
    Friend WithEvents LabelCantYPrecio As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents ButtonVerListas As System.Windows.Forms.Button
    Friend WithEvents TextBoxNombreCliente As TextBox
    Friend WithEvents TextBoxNombreArticulo As TextBox
    Friend WithEvents TextBoxCantYPrecio As TextBox
    Friend WithEvents TextBoxTotal As TextBox
End Class
