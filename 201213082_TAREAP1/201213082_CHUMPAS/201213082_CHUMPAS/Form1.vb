Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BttCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCalcular.Click
        If RbS.Checked = False Or RbM.Checked = False Or RbL.Checked = False Then
            MsgBox("No has elegido tamaño")
            End
        End If

        If RbA.Checked = False Or RbSeda.Checked = False Or RbLana.Checked = False Then
            MsgBox("No has elegido material")
            End
        End If

        If TextBox1.Text = "" Then
            MsgBox("No ha ingresado cantidad")
            End
        End If

        Dim tamaño As String
        Dim material As String

        If RbS.Checked Then
            tamaño = "Small"
        ElseIf RbL.Checked Then
            tamaño = "Medium"
        Else
            tamaño = "Large"
        End If

        If RbA.Checked Then
            material = "Algodón"
        ElseIf RbSeda.Checked Then
            material = "Seda"
        Else
            material = "Lana"
        End If

        calcular(material, tamaño, Val(TextBox1.Text))
        Me.Hide()
        Form2.Show()


    End Sub

    Private Sub BttLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttLimpiar.Click
        TextBox1.Text = ""
        RbA.Checked = False
        RbL.Checked = False
        RbLana.Checked = False
        RbM.Checked = False
        RbS.Checked = False
        RbSeda.Checked = False

    End Sub

    Private Sub BttCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttCerrar.Click
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
