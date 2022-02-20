<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LbPrecio = New System.Windows.Forms.Label()
        Me.LbPrecioventa = New System.Windows.Forms.Label()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.TxtVenta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LbPrecio
        '
        Me.LbPrecio.AutoSize = True
        Me.LbPrecio.Location = New System.Drawing.Point(29, 66)
        Me.LbPrecio.Name = "LbPrecio"
        Me.LbPrecio.Size = New System.Drawing.Size(131, 17)
        Me.LbPrecio.TabIndex = 0
        Me.LbPrecio.Text = "Precio de costo (Q)"
        '
        'LbPrecioventa
        '
        Me.LbPrecioventa.AutoSize = True
        Me.LbPrecioventa.Location = New System.Drawing.Point(32, 110)
        Me.LbPrecioventa.Name = "LbPrecioventa"
        Me.LbPrecioventa.Size = New System.Drawing.Size(132, 17)
        Me.LbPrecioventa.TabIndex = 1
        Me.LbPrecioventa.Text = "Precio de venta (Q)"
        '
        'TxtCosto
        '
        Me.TxtCosto.Enabled = False
        Me.TxtCosto.Location = New System.Drawing.Point(216, 66)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(100, 22)
        Me.TxtCosto.TabIndex = 2
        '
        'TxtVenta
        '
        Me.TxtVenta.Enabled = False
        Me.TxtVenta.Location = New System.Drawing.Point(216, 110)
        Me.TxtVenta.Name = "TxtVenta"
        Me.TxtVenta.Size = New System.Drawing.Size(100, 22)
        Me.TxtVenta.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(447, 253)
        Me.Controls.Add(Me.TxtVenta)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.LbPrecioventa)
        Me.Controls.Add(Me.LbPrecio)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbPrecio As System.Windows.Forms.Label
    Friend WithEvents LbPrecioventa As System.Windows.Forms.Label
    Friend WithEvents TxtCosto As System.Windows.Forms.TextBox
    Friend WithEvents TxtVenta As System.Windows.Forms.TextBox
End Class
