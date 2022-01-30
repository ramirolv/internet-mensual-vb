<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewClient
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxDpi = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBoxDireccion)
        Me.Panel1.Controls.Add(Me.TextBoxTelefono)
        Me.Panel1.Controls.Add(Me.TextBoxNombre)
        Me.Panel1.Controls.Add(Me.TextBoxDpi)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 278)
        Me.Panel1.TabIndex = 0
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDireccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDireccion.Location = New System.Drawing.Point(12, 153)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxDireccion.TabIndex = 4
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefono.Location = New System.Drawing.Point(12, 120)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxTelefono.TabIndex = 3
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(12, 87)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxNombre.TabIndex = 2
        '
        'TextBoxDpi
        '
        Me.TextBoxDpi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDpi.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDpi.Location = New System.Drawing.Point(12, 54)
        Me.TextBoxDpi.Name = "TextBoxDpi"
        Me.TextBoxDpi.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxDpi.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(69, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NewClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 278)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NewClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewClient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDpi As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
