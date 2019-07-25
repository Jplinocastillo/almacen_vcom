<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btmlogin = New System.Windows.Forms.Button()
        Me.linkpass = New System.Windows.Forms.LinkLabel()
        Me.btminim = New System.Windows.Forms.PictureBox()
        Me.btmcerrar1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btminim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btmcerrar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 236)
        Me.Panel1.TabIndex = 0
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuser.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.White
        Me.txtuser.Location = New System.Drawing.Point(301, 53)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(200, 28)
        Me.txtuser.TabIndex = 1
        Me.txtuser.Text = "USUARIO"
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.White
        Me.txtpass.Location = New System.Drawing.Point(301, 116)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(200, 28)
        Me.txtpass.TabIndex = 2
        Me.txtpass.Text = "CONTRASEÑA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(368, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LOGIN"
        '
        'btmlogin
        '
        Me.btmlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btmlogin.FlatAppearance.BorderSize = 0
        Me.btmlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btmlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btmlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmlogin.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmlogin.ForeColor = System.Drawing.Color.White
        Me.btmlogin.Location = New System.Drawing.Point(236, 174)
        Me.btmlogin.Name = "btmlogin"
        Me.btmlogin.Size = New System.Drawing.Size(317, 29)
        Me.btmlogin.TabIndex = 4
        Me.btmlogin.Text = "ACCEDER"
        Me.btmlogin.UseVisualStyleBackColor = False
        '
        'linkpass
        '
        Me.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.linkpass.AutoSize = True
        Me.linkpass.LinkColor = System.Drawing.Color.Gray
        Me.linkpass.Location = New System.Drawing.Point(318, 208)
        Me.linkpass.Name = "linkpass"
        Me.linkpass.Size = New System.Drawing.Size(149, 13)
        Me.linkpass.TabIndex = 5
        Me.linkpass.TabStop = True
        Me.linkpass.Text = "¿Has olvidado tu contraseña?"
        '
        'btminim
        '
        Me.btminim.BackgroundImage = Global.almacenvcom1.My.Resources.Resources.Icono_Minimizar
        Me.btminim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btminim.Location = New System.Drawing.Point(561, 0)
        Me.btminim.Name = "btminim"
        Me.btminim.Size = New System.Drawing.Size(15, 15)
        Me.btminim.TabIndex = 7
        Me.btminim.TabStop = False
        '
        'btmcerrar1
        '
        Me.btmcerrar1.BackgroundImage = Global.almacenvcom1.My.Resources.Resources.Icono_cerrar_FN
        Me.btmcerrar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmcerrar1.Location = New System.Drawing.Point(574, 0)
        Me.btmcerrar1.Name = "btmcerrar1"
        Me.btmcerrar1.Size = New System.Drawing.Size(15, 15)
        Me.btmcerrar1.TabIndex = 6
        Me.btmcerrar1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.almacenvcom1.My.Resources.Resources.Sin_título_1modi1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(33, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 93)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(588, 236)
        Me.Controls.Add(Me.btminim)
        Me.Controls.Add(Me.btmcerrar1)
        Me.Controls.Add(Me.linkpass)
        Me.Controls.Add(Me.btmlogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btminim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btmcerrar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btmlogin As Button
    Friend WithEvents linkpass As LinkLabel
    Friend WithEvents btmcerrar1 As PictureBox
    Friend WithEvents btminim As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
