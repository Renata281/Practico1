<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MiPrimerForms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BGuardar = New Button()
        BEliminar = New Button()
        LNombre = New Label()
        LApellido = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        BSalir = New Button()
        SuspendLayout()
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(27, 164)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(67, 27)
        BGuardar.TabIndex = 0
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(118, 164)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(75, 27)
        BEliminar.TabIndex = 1
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(27, 115)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 2
        LNombre.Text = "Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(27, 69)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(95, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(112, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(95, 112)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(112, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(255, 66)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(188, 106)
        TextBox3.TabIndex = 6
        ' 
        ' BSalir
        ' 
        BSalir.Location = New Point(386, 226)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(75, 23)
        BSalir.TabIndex = 7
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 261)
        Controls.Add(BSalir)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LApellido)
        Controls.Add(LNombre)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        KeyPreview = True
        Name = "Form1"
        Text = "Mi primer forms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BSalir As Button

End Class
