<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_MontoPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_MontoPagar))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMontoPagado1 = New DevComponents.DotNetBar.LabelX()
        Me.txtCambio1 = New DevComponents.DotNetBar.LabelX()
        Me.lbCambio = New DevComponents.DotNetBar.LabelX()
        Me.lbMontoPagado = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.tbMontoTarej = New DevComponents.Editors.DoubleInput()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.chbTarjeta = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.tbMontoBs = New DevComponents.Editors.DoubleInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.tbMontoDolar = New DevComponents.Editors.DoubleInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbRazonSocial = New System.Windows.Forms.TextBox()
        Me.tbNit = New System.Windows.Forms.TextBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.btnContinuar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbMontoTarej, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMontoBs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMontoDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.DinoM.My.Resources.Resources.fondo1
        Me.GroupBox2.Controls.Add(Me.BtnSalir)
        Me.GroupBox2.Controls.Add(Me.btnContinuar)
        Me.GroupBox2.Controls.Add(Me.txtMontoPagado1)
        Me.GroupBox2.Controls.Add(Me.txtCambio1)
        Me.GroupBox2.Controls.Add(Me.lbCambio)
        Me.GroupBox2.Controls.Add(Me.lbMontoPagado)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(0, 278)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(566, 170)
        Me.GroupBox2.TabIndex = 364
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monto Pagado/Cambio:"
        '
        'txtMontoPagado1
        '
        Me.txtMontoPagado1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMontoPagado1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMontoPagado1.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPagado1.ForeColor = System.Drawing.Color.YellowGreen
        Me.txtMontoPagado1.Location = New System.Drawing.Point(120, 28)
        Me.txtMontoPagado1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMontoPagado1.Name = "txtMontoPagado1"
        Me.txtMontoPagado1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.txtMontoPagado1.Size = New System.Drawing.Size(160, 49)
        Me.txtMontoPagado1.TabIndex = 369
        Me.txtMontoPagado1.Text = "0.00"
        Me.txtMontoPagado1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtCambio1
        '
        Me.txtCambio1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCambio1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCambio1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambio1.ForeColor = System.Drawing.Color.YellowGreen
        Me.txtCambio1.Location = New System.Drawing.Point(398, 26)
        Me.txtCambio1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCambio1.Name = "txtCambio1"
        Me.txtCambio1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.txtCambio1.Size = New System.Drawing.Size(147, 49)
        Me.txtCambio1.TabIndex = 368
        Me.txtCambio1.Text = "0.00"
        Me.txtCambio1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbCambio
        '
        Me.lbCambio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCambio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCambio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCambio.ForeColor = System.Drawing.Color.White
        Me.lbCambio.Location = New System.Drawing.Point(292, 34)
        Me.lbCambio.Margin = New System.Windows.Forms.Padding(4)
        Me.lbCambio.Name = "lbCambio"
        Me.lbCambio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCambio.Size = New System.Drawing.Size(87, 22)
        Me.lbCambio.TabIndex = 367
        Me.lbCambio.Text = "Cambio:"
        '
        'lbMontoPagado
        '
        Me.lbMontoPagado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbMontoPagado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMontoPagado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMontoPagado.ForeColor = System.Drawing.Color.White
        Me.lbMontoPagado.Location = New System.Drawing.Point(3, 35)
        Me.lbMontoPagado.Margin = New System.Windows.Forms.Padding(4)
        Me.lbMontoPagado.Name = "lbMontoPagado"
        Me.lbMontoPagado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbMontoPagado.Size = New System.Drawing.Size(135, 22)
        Me.lbMontoPagado.TabIndex = 366
        Me.lbMontoPagado.Text = "M.Pagado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.DinoM.My.Resources.Resources.fondo1
        Me.GroupBox1.Controls.Add(Me.ButtonX3)
        Me.GroupBox1.Controls.Add(Me.tbMontoTarej)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.chbTarjeta)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.tbMontoBs)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.tbMontoDolar)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(566, 142)
        Me.GroupBox1.TabIndex = 362
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Efectivo:"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX3.Image = CType(resources.GetObject("ButtonX3.Image"), System.Drawing.Image)
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.ButtonX3.Location = New System.Drawing.Point(459, 86)
        Me.ButtonX3.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(80, 25)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 363
        Me.ButtonX3.Visible = False
        '
        'tbMontoTarej
        '
        '
        '
        '
        Me.tbMontoTarej.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbMontoTarej.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMontoTarej.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbMontoTarej.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMontoTarej.ForeColor = System.Drawing.Color.Black
        Me.tbMontoTarej.Increment = 1.0R
        Me.tbMontoTarej.Location = New System.Drawing.Point(124, 84)
        Me.tbMontoTarej.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMontoTarej.MinValue = 0R
        Me.tbMontoTarej.Name = "tbMontoTarej"
        Me.tbMontoTarej.Size = New System.Drawing.Size(160, 30)
        Me.tbMontoTarej.TabIndex = 4
        Me.tbMontoTarej.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.ButtonX2.Location = New System.Drawing.Point(381, 87)
        Me.ButtonX2.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(80, 25)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 362
        Me.ButtonX2.Visible = False
        '
        'chbTarjeta
        '
        Me.chbTarjeta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chbTarjeta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbTarjeta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTarjeta.Location = New System.Drawing.Point(5, 80)
        Me.chbTarjeta.Margin = New System.Windows.Forms.Padding(4)
        Me.chbTarjeta.Name = "chbTarjeta"
        Me.chbTarjeta.Size = New System.Drawing.Size(116, 37)
        Me.chbTarjeta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbTarjeta.TabIndex = 279
        Me.chbTarjeta.Text = "Tarjeta:"
        Me.chbTarjeta.TextColor = System.Drawing.Color.White
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.ButtonX1.Location = New System.Drawing.Point(303, 86)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(80, 25)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 360
        Me.ButtonX1.Visible = False
        '
        'tbMontoBs
        '
        '
        '
        '
        Me.tbMontoBs.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbMontoBs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMontoBs.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbMontoBs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMontoBs.ForeColor = System.Drawing.Color.Black
        Me.tbMontoBs.Increment = 1.0R
        Me.tbMontoBs.Location = New System.Drawing.Point(124, 39)
        Me.tbMontoBs.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMontoBs.MinValue = 0R
        Me.tbMontoBs.Name = "tbMontoBs"
        Me.tbMontoBs.Size = New System.Drawing.Size(160, 30)
        Me.tbMontoBs.TabIndex = 2
        Me.tbMontoBs.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.White
        Me.LabelX5.Location = New System.Drawing.Point(4, 43)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX5.Size = New System.Drawing.Size(113, 22)
        Me.LabelX5.TabIndex = 64
        Me.LabelX5.Text = "M.Pagado:"
        '
        'tbMontoDolar
        '
        '
        '
        '
        Me.tbMontoDolar.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbMontoDolar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMontoDolar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbMontoDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMontoDolar.ForeColor = System.Drawing.Color.Black
        Me.tbMontoDolar.Increment = 1.0R
        Me.tbMontoDolar.Location = New System.Drawing.Point(399, 41)
        Me.tbMontoDolar.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMontoDolar.MinValue = 0R
        Me.tbMontoDolar.Name = "tbMontoDolar"
        Me.tbMontoDolar.Size = New System.Drawing.Size(147, 30)
        Me.tbMontoDolar.TabIndex = 3
        Me.tbMontoDolar.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.White
        Me.LabelX6.Location = New System.Drawing.Point(296, 43)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX6.Size = New System.Drawing.Size(93, 22)
        Me.LabelX6.TabIndex = 66
        Me.LabelX6.Text = "Mont. $:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImage = Global.DinoM.My.Resources.Resources.fondo1
        Me.GroupBox3.Controls.Add(Me.tbRazonSocial)
        Me.GroupBox3.Controls.Add(Me.tbNit)
        Me.GroupBox3.Controls.Add(Me.LabelX3)
        Me.GroupBox3.Controls.Add(Me.LabelX4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(566, 136)
        Me.GroupBox3.TabIndex = 365
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Factura"
        '
        'tbRazonSocial
        '
        Me.tbRazonSocial.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRazonSocial.Location = New System.Drawing.Point(124, 71)
        Me.tbRazonSocial.Name = "tbRazonSocial"
        Me.tbRazonSocial.Size = New System.Drawing.Size(435, 28)
        Me.tbRazonSocial.TabIndex = 1
        '
        'tbNit
        '
        Me.tbNit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNit.Location = New System.Drawing.Point(124, 25)
        Me.tbNit.Name = "tbNit"
        Me.tbNit.Size = New System.Drawing.Size(325, 32)
        Me.tbNit.TabIndex = 0
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.White
        Me.LabelX3.Location = New System.Drawing.Point(8, 35)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX3.Size = New System.Drawing.Size(87, 22)
        Me.LabelX3.TabIndex = 367
        Me.LabelX3.Text = "Nit:"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.White
        Me.LabelX4.Location = New System.Drawing.Point(8, 77)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX4.Size = New System.Drawing.Size(135, 22)
        Me.LabelX4.TabIndex = 366
        Me.LabelX4.Text = "Razón Social:"
        '
        'btnContinuar
        '
        Me.btnContinuar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnContinuar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnContinuar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Image = Global.DinoM.My.Resources.Resources.checked
        Me.btnContinuar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnContinuar.Location = New System.Drawing.Point(398, 110)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(147, 48)
        Me.btnContinuar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnContinuar.TabIndex = 370
        Me.btnContinuar.Text = "Continuar"
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.BtnSalir.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.DinoM.My.Resources.Resources.cancel
        Me.BtnSalir.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.BtnSalir.Location = New System.Drawing.Point(236, 110)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(147, 48)
        Me.BtnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BtnSalir.TabIndex = 371
        Me.BtnSalir.Text = "Salir"
        '
        'F1_MontoPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 448)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F1_MontoPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F1_MontoPagar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.tbMontoTarej, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMontoBs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMontoDolar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbMontoTarej As DevComponents.Editors.DoubleInput
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chbTarjeta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbMontoBs As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbMontoDolar As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMontoPagado1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCambio1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbCambio As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbMontoPagado As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbRazonSocial As TextBox
    Friend WithEvents tbNit As TextBox
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnContinuar As DevComponents.DotNetBar.ButtonX
End Class
