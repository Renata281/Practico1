Public Class MiPrimerForms
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim apellido As String = TextBox1.Text
        Dim nombre As String = TextBox2.Text
        Dim nombreCompleto As String = apellido & " " & nombre

        TextBox3.Text = nombreCompleto

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TextBox3.Clear()

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        ' Cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica si se presiono la tecla S y si la tecla Ctrl esta presionada
        If e.KeyCode = Keys.S AndAlso e.Control Then
            'Cierra el formulario actual
            Me.Close()
        End If
    End Sub
End Class
