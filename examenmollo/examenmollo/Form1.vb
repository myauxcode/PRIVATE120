Public Class Form1
    Dim v1, v2, v3, v4 As Vector
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New Vector
        v2 = New Vector
        v3 = New Vector
        v4 = New Vector
    End Sub

    Private Sub CargarV1RandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarV1RandomToolStripMenuItem.Click
        v1.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox4.Text = v1.descargar
    End Sub

    Private Sub DescargarV1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarV1ToolStripMenuItem.Click
        TextBox4.Text = v1.descargar
    End Sub

    Private Sub CargarV2RandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarV2RandomToolStripMenuItem.Click
        v2.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox5.Text = v2.descargar
    End Sub

    Private Sub DescargarV2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarV2ToolStripMenuItem.Click
        TextBox4.Text = v2.descargar
    End Sub

    Private Sub Pregunta1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta1ToolStripMenuItem.Click
        v3 = New Vector
        v4 = New Vector
        v1.examen(v2, v3, v4)
        TextBox6.Text = v3.descargar
        TextBox7.Text = v4.descargar
    End Sub
End Class
