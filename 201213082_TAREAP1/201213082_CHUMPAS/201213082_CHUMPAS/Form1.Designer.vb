<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbL = New System.Windows.Forms.RadioButton()
        Me.RbM = New System.Windows.Forms.RadioButton()
        Me.RbS = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbLana = New System.Windows.Forms.RadioButton()
        Me.RbSeda = New System.Windows.Forms.RadioButton()
        Me.RbA = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BttCalcular = New System.Windows.Forms.Button()
        Me.BttLimpiar = New System.Windows.Forms.Button()
        Me.BttCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbL)
        Me.GroupBox1.Controls.Add(Me.RbM)
        Me.GroupBox1.Controls.Add(Me.RbS)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño "
        '
        'RbL
        '
        Me.RbL.AutoSize = True
        Me.RbL.Location = New System.Drawing.Point(17, 117)
        Me.RbL.Name = "RbL"
        Me.RbL.Size = New System.Drawing.Size(66, 21)
        Me.RbL.TabIndex = 2
        Me.RbL.TabStop = True
        Me.RbL.Text = "Large"
        Me.RbL.UseVisualStyleBackColor = True
        '
        'RbM
        '
        Me.RbM.AutoSize = True
        Me.RbM.Location = New System.Drawing.Point(17, 78)
        Me.RbM.Name = "RbM"
        Me.RbM.Size = New System.Drawing.Size(78, 21)
        Me.RbM.TabIndex = 1
        Me.RbM.TabStop = True
        Me.RbM.Text = "Medium"
        Me.RbM.UseVisualStyleBackColor = True
        '
        'RbS
        '
        Me.RbS.AutoSize = True
        Me.RbS.Location = New System.Drawing.Point(17, 39)
        Me.RbS.Name = "RbS"
        Me.RbS.Size = New System.Drawing.Size(63, 21)
        Me.RbS.TabIndex = 0
        Me.RbS.TabStop = True
        Me.RbS.Text = "Small"
        Me.RbS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbLana)
        Me.GroupBox2.Controls.Add(Me.RbSeda)
        Me.GroupBox2.Controls.Add(Me.RbA)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(123, 144)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'RbLana
        '
        Me.RbLana.AutoSize = True
        Me.RbLana.Location = New System.Drawing.Point(7, 117)
        Me.RbLana.Name = "RbLana"
        Me.RbLana.Size = New System.Drawing.Size(61, 21)
        Me.RbLana.TabIndex = 2
        Me.RbLana.TabStop = True
        Me.RbLana.Text = "Lana"
        Me.RbLana.UseVisualStyleBackColor = True
        '
        'RbSeda
        '
        Me.RbSeda.AutoSize = True
        Me.RbSeda.Location = New System.Drawing.Point(7, 78)
        Me.RbSeda.Name = "RbSeda"
        Me.RbSeda.Size = New System.Drawing.Size(62, 21)
        Me.RbSeda.TabIndex = 1
        Me.RbSeda.TabStop = True
        Me.RbSeda.Text = "Seda"
        Me.RbSeda.UseVisualStyleBackColor = True
        '
        'RbA
        '
        Me.RbA.AutoSize = True
        Me.RbA.Location = New System.Drawing.Point(7, 39)
        Me.RbA.Name = "RbA"
        Me.RbA.Size = New System.Drawing.Size(81, 21)
        Me.RbA.TabIndex = 0
        Me.RbA.TabStop = True
        Me.RbA.Text = "Algodón"
        Me.RbA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad de chumpas"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 22)
        Me.TextBox1.TabIndex = 3
        '
        'BttCalcular
        '
        Me.BttCalcular.Location = New System.Drawing.Point(36, 239)
        Me.BttCalcular.Name = "BttCalcular"
        Me.BttCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BttCalcular.TabIndex = 4
        Me.BttCalcular.Text = "Calcular"
        Me.BttCalcular.UseVisualStyleBackColor = True
        '
        'BttLimpiar
        '
        Me.BttLimpiar.Location = New System.Drawing.Point(149, 239)
        Me.BttLimpiar.Name = "BttLimpiar"
        Me.BttLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BttLimpiar.TabIndex = 5
        Me.BttLimpiar.Text = "Limpiar"
        Me.BttLimpiar.UseVisualStyleBackColor = True
        '
        'BttCerrar
        '
        Me.BttCerrar.Location = New System.Drawing.Point(256, 239)
        Me.BttCerrar.Name = "BttCerrar"
        Me.BttCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BttCerrar.TabIndex = 6
        Me.BttCerrar.Text = "Cerrar"
        Me.BttCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(379, 308)
        Me.Controls.Add(Me.BttCerrar)
        Me.Controls.Add(Me.BttLimpiar)
        Me.Controls.Add(Me.BttCalcular)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbL As System.Windows.Forms.RadioButton
    Friend WithEvents RbM As System.Windows.Forms.RadioButton
    Friend WithEvents RbS As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbLana As System.Windows.Forms.RadioButton
    Friend WithEvents RbSeda As System.Windows.Forms.RadioButton
    Friend WithEvents RbA As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BttCalcular As System.Windows.Forms.Button
    Friend WithEvents BttLimpiar As System.Windows.Forms.Button
    Friend WithEvents BttCerrar As System.Windows.Forms.Button

End Class
