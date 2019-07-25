<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.btmrestaurar = New System.Windows.Forms.Button()
        Me.btminimizar = New System.Windows.Forms.Button()
        Me.btmaximizar = New System.Windows.Forms.Button()
        Me.btmcerrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btmatras = New System.Windows.Forms.Button()
        Me.btmct = New System.Windows.Forms.Button()
        Me.btmsyscom = New System.Windows.Forms.Button()
        Me.btmgarantias = New System.Windows.Forms.Button()
        Me.btmproveedores = New System.Windows.Forms.Button()
        Me.btmalmacen = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btmrestaurar)
        Me.Panel1.Controls.Add(Me.btminimizar)
        Me.Panel1.Controls.Add(Me.btmaximizar)
        Me.Panel1.Controls.Add(Me.btmcerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 29)
        Me.Panel1.TabIndex = 0
        '
        'btmrestaurar
        '
        Me.btmrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btmrestaurar.BackColor = System.Drawing.Color.Transparent
        Me.btmrestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmrestaurar.FlatAppearance.BorderSize = 0
        Me.btmrestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btmrestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btmrestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmrestaurar.Image = Global.almacenvcom1.My.Resources.Resources.Icono_Restaurar
        Me.btmrestaurar.Location = New System.Drawing.Point(1032, 0)
        Me.btmrestaurar.Name = "btmrestaurar"
        Me.btmrestaurar.Size = New System.Drawing.Size(31, 29)
        Me.btmrestaurar.TabIndex = 4
        Me.btmrestaurar.UseVisualStyleBackColor = False
        Me.btmrestaurar.Visible = False
        '
        'btminimizar
        '
        Me.btminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btminimizar.BackColor = System.Drawing.Color.Transparent
        Me.btminimizar.BackgroundImage = Global.almacenvcom1.My.Resources.Resources.Icono_Minimizar1
        Me.btminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btminimizar.FlatAppearance.BorderSize = 0
        Me.btminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btminimizar.Location = New System.Drawing.Point(995, 0)
        Me.btminimizar.Name = "btminimizar"
        Me.btminimizar.Size = New System.Drawing.Size(31, 29)
        Me.btminimizar.TabIndex = 4
        Me.btminimizar.UseVisualStyleBackColor = False
        '
        'btmaximizar
        '
        Me.btmaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btmaximizar.BackColor = System.Drawing.Color.Transparent
        Me.btmaximizar.BackgroundImage = Global.almacenvcom1.My.Resources.Resources.Icono_Maximizar
        Me.btmaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmaximizar.FlatAppearance.BorderSize = 0
        Me.btmaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btmaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btmaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmaximizar.Location = New System.Drawing.Point(1032, 0)
        Me.btmaximizar.Name = "btmaximizar"
        Me.btmaximizar.Size = New System.Drawing.Size(31, 29)
        Me.btmaximizar.TabIndex = 3
        Me.btmaximizar.UseVisualStyleBackColor = False
        '
        'btmcerrar
        '
        Me.btmcerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btmcerrar.BackColor = System.Drawing.Color.Transparent
        Me.btmcerrar.BackgroundImage = Global.almacenvcom1.My.Resources.Resources.Icono_cerrar_FN1
        Me.btmcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmcerrar.FlatAppearance.BorderSize = 0
        Me.btmcerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btmcerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btmcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmcerrar.Location = New System.Drawing.Point(1069, 0)
        Me.btmcerrar.Name = "btmcerrar"
        Me.btmcerrar.Size = New System.Drawing.Size(31, 29)
        Me.btmcerrar.TabIndex = 2
        Me.btmcerrar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.btmatras)
        Me.Panel2.Controls.Add(Me.btmct)
        Me.Panel2.Controls.Add(Me.btmsyscom)
        Me.Panel2.Controls.Add(Me.btmgarantias)
        Me.Panel2.Controls.Add(Me.btmproveedores)
        Me.Panel2.Controls.Add(Me.btmalmacen)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 551)
        Me.Panel2.TabIndex = 1
        '
        'btmatras
        '
        Me.btmatras.FlatAppearance.BorderSize = 0
        Me.btmatras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btmatras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btmatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmatras.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmatras.ForeColor = System.Drawing.Color.White
        Me.btmatras.Location = New System.Drawing.Point(0, 3)
        Me.btmatras.Name = "btmatras"
        Me.btmatras.Size = New System.Drawing.Size(220, 41)
        Me.btmatras.TabIndex = 5
        Me.btmatras.Text = "Atras"
        Me.btmatras.UseVisualStyleBackColor = True
        Me.btmatras.Visible = False
        '
        'btmct
        '
        Me.btmct.BackgroundImage = Global.almacenvcom1.My.Resources.Resources.logo_ct
        Me.btmct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmct.FlatAppearance.BorderSize = 0
        Me.btmct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btmct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btmct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmct.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmct.ForeColor = System.Drawing.Color.White
        Me.btmct.Location = New System.Drawing.Point(0, 194)
        Me.btmct.Name = "btmct"
        Me.btmct.Size = New System.Drawing.Size(220, 41)
        Me.btmct.TabIndex = 4
        Me.btmct.UseVisualStyleBackColor = True
        Me.btmct.Visible = False
        '
        'btmsyscom
        '
        Me.btmsyscom.BackgroundImage = Global.almacenvcom1.My.Resources.Resources.syscom
        Me.btmsyscom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmsyscom.FlatAppearance.BorderSize = 0
        Me.btmsyscom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btmsyscom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btmsyscom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmsyscom.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmsyscom.ForeColor = System.Drawing.Color.White
        Me.btmsyscom.Location = New System.Drawing.Point(0, 241)
        Me.btmsyscom.Name = "btmsyscom"
        Me.btmsyscom.Size = New System.Drawing.Size(220, 41)
        Me.btmsyscom.TabIndex = 3
        Me.btmsyscom.UseVisualStyleBackColor = True
        Me.btmsyscom.Visible = False
        '
        'btmgarantias
        '
        Me.btmgarantias.FlatAppearance.BorderSize = 0
        Me.btmgarantias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btmgarantias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btmgarantias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmgarantias.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmgarantias.ForeColor = System.Drawing.Color.White
        Me.btmgarantias.Location = New System.Drawing.Point(0, 241)
        Me.btmgarantias.Name = "btmgarantias"
        Me.btmgarantias.Size = New System.Drawing.Size(220, 41)
        Me.btmgarantias.TabIndex = 2
        Me.btmgarantias.Text = "Garantías"
        Me.btmgarantias.UseVisualStyleBackColor = True
        '
        'btmproveedores
        '
        Me.btmproveedores.FlatAppearance.BorderSize = 0
        Me.btmproveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btmproveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btmproveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmproveedores.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmproveedores.ForeColor = System.Drawing.Color.White
        Me.btmproveedores.Location = New System.Drawing.Point(0, 147)
        Me.btmproveedores.Name = "btmproveedores"
        Me.btmproveedores.Size = New System.Drawing.Size(220, 41)
        Me.btmproveedores.TabIndex = 1
        Me.btmproveedores.Text = "Proveedores"
        Me.btmproveedores.UseVisualStyleBackColor = True
        '
        'btmalmacen
        '
        Me.btmalmacen.FlatAppearance.BorderSize = 0
        Me.btmalmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btmalmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btmalmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmalmacen.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmalmacen.ForeColor = System.Drawing.Color.White
        Me.btmalmacen.Location = New System.Drawing.Point(0, 194)
        Me.btmalmacen.Name = "btmalmacen"
        Me.btmalmacen.Size = New System.Drawing.Size(220, 41)
        Me.btmalmacen.TabIndex = 0
        Me.btmalmacen.Text = "Almacen"
        Me.btmalmacen.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.almacenvcom1.My.Resources.Resources.Sin_título_1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.WebBrowser2)
        Me.Panel3.Controls.Add(Me.WebBrowser1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(220, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(880, 551)
        Me.Panel3.TabIndex = 2
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(880, 551)
        Me.WebBrowser2.TabIndex = 1
        Me.WebBrowser2.Url = New System.Uri("https://ctonline.mx/", System.UriKind.Absolute)
        Me.WebBrowser2.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(880, 551)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("https://www.syscom.mx/", System.UriKind.Absolute)
        Me.WebBrowser1.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btmcerrar As Button
    Friend WithEvents btmaximizar As Button
    Friend WithEvents btminimizar As Button
    Friend WithEvents btmrestaurar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btmgarantias As Button
    Friend WithEvents btmproveedores As Button
    Friend WithEvents btmalmacen As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btmct As Button
    Friend WithEvents btmsyscom As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btmatras As Button
    Friend WithEvents WebBrowser2 As WebBrowser
End Class
