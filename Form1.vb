Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim var As Integer
        var = InputBox("Ingrese un numero del 1 al 12: ")
        If (var >= 1 And var <= 12) Then
            Select Case var
                Case 1
                    MsgBox("Enero")
                Case 2
                    MsgBox("Febrero")
                Case 3
                    MsgBox("Marzo")
                Case 4
                    MsgBox("Abril")
                Case 5
                    MsgBox("Mayo")
                Case 6
                    MsgBox("Junio")
                Case 7
                    MsgBox("Julio")
                Case 8
                    MsgBox("Agosto")
                Case 9
                    MsgBox("Septiembre")
                Case 10
                    MsgBox("Octubre")
                Case 11
                    MsgBox("Noviembre")
                Case 12
                    MsgBox("Diciembre")

            End Select
        Else
            MsgBox("El numero ingresado no es correcto")

        End If
    End Sub
End Class
