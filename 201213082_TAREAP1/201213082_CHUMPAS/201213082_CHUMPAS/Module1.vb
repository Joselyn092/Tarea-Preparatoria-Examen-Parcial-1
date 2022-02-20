Module Module1
    Public Const manodeobraS = 65.5
    Public Const manodeobraM = 85.99
    Public Const manodeobraL = 99.99

    Public Const precioalgodon = 15
    Public Const precioseda = 23.99
    Public Const preciolana = 30.99

    Public Const cantidadS = 2
    Public Const cantidadM = 2.5
    Public Const cantidadL = 3

    Public preciocosto = 0
    Public precioventa = 0

    Public Sub calcular(ByVal material As String, ByVal tamaño As String, ByVal cantidad As Double)
        Select Case tamaño
            Case "Small"
                Select Case material
                    Case "algodón"
                        preciocosto = cantidad * manodeobraS + cantidad * precioalgodon * cantidadS
                    Case "Seda"
                        preciocosto = cantidad * manodeobraS + cantidad * precioseda * cantidadS
                    Case "Lana"
                        preciocosto = cantidad * manodeobraS + cantidad * preciolana * cantidadS
                End Select
        End Select

        Select Case tamaño
            Case "Medium"
                Select Case material
                    Case "algodón"
                        preciocosto = cantidad * manodeobraM + cantidad * precioalgodon * cantidadM
                    Case "Seda"
                        preciocosto = cantidad * manodeobraM + cantidad * precioseda * cantidadM
                    Case "Lana"
                        preciocosto = cantidad * manodeobraM + cantidad * preciolana * cantidadM
                End Select
        End Select

        Select Case tamaño
            Case "Large"
                Select Case material
                    Case "algodón"
                        preciocosto = cantidad * manodeobraL + cantidad * precioalgodon * cantidadL
                    Case "Seda"
                        preciocosto = cantidad * manodeobraL + cantidad * precioseda * cantidadL
                    Case "Lana"
                        preciocosto = cantidad * manodeobraL + cantidad * preciolana * cantidadL
                End Select
        End Select

        precioventa = preciocosto + 0.65 * preciocosto

    End Sub
End Module
