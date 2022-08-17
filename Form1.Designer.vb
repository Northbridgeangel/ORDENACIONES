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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.COMBODESORDEN = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.COMBOORDEN = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "BURBUJA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'COMBODESORDEN
        '
        Me.COMBODESORDEN.FormattingEnabled = True
        Me.COMBODESORDEN.Location = New System.Drawing.Point(256, 56)
        Me.COMBODESORDEN.Name = "COMBODESORDEN"
        Me.COMBODESORDEN.Size = New System.Drawing.Size(152, 21)
        Me.COMBODESORDEN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(256, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VECTOR DESORDENADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(424, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "VECTOR ORDENADO"
        '
        'COMBOORDEN
        '
        Me.COMBOORDEN.FormattingEnabled = True
        Me.COMBOORDEN.Location = New System.Drawing.Point(424, 56)
        Me.COMBOORDEN.Name = "COMBOORDEN"
        Me.COMBOORDEN.Size = New System.Drawing.Size(152, 21)
        Me.COMBOORDEN.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "INSERCION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 40)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "BUSCAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(160, 312)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(160, 336)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(8, 184)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 40)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "QUICKSORT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(192, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(560, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Metodos de Ordenacion de Vectores y Busqueda Binaria"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("DS-Digital", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(152, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 36)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.COMBOORDEN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.COMBODESORDEN)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "METODOS DE ORDENACION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents COMBODESORDEN As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents COMBOORDEN As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
End Class
