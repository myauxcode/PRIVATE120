<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarV1RandomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarV1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarV2RandomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarV2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pregunta1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(70, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(219, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(379, 43)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(70, 124)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(409, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(70, 174)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(409, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(70, 227)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(409, 20)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(70, 275)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(409, 20)
        Me.TextBox7.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarV1RandomToolStripMenuItem, Me.DescargarV1ToolStripMenuItem, Me.CargarV2RandomToolStripMenuItem, Me.DescargarV2ToolStripMenuItem, Me.Pregunta1ToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "menu"
        '
        'CargarV1RandomToolStripMenuItem
        '
        Me.CargarV1RandomToolStripMenuItem.Name = "CargarV1RandomToolStripMenuItem"
        Me.CargarV1RandomToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CargarV1RandomToolStripMenuItem.Text = "cargar v1 random"
        '
        'DescargarV1ToolStripMenuItem
        '
        Me.DescargarV1ToolStripMenuItem.Name = "DescargarV1ToolStripMenuItem"
        Me.DescargarV1ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DescargarV1ToolStripMenuItem.Text = "descargar v1"
        '
        'CargarV2RandomToolStripMenuItem
        '
        Me.CargarV2RandomToolStripMenuItem.Name = "CargarV2RandomToolStripMenuItem"
        Me.CargarV2RandomToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CargarV2RandomToolStripMenuItem.Text = "cargar v2 random"
        '
        'DescargarV2ToolStripMenuItem
        '
        Me.DescargarV2ToolStripMenuItem.Name = "DescargarV2ToolStripMenuItem"
        Me.DescargarV2ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DescargarV2ToolStripMenuItem.Text = "descargar v2"
        '
        'Pregunta1ToolStripMenuItem
        '
        Me.Pregunta1ToolStripMenuItem.Name = "Pregunta1ToolStripMenuItem"
        Me.Pregunta1ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.Pregunta1ToolStripMenuItem.Text = "pregunta 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 381)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarV1RandomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescargarV1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarV2RandomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescargarV2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pregunta1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
