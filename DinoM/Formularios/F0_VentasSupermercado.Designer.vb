﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F0_VentasSupermercado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F0_VentasSupermercado))
        Me.PanelImagen = New System.Windows.Forms.Panel()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.PanelC = New System.Windows.Forms.Panel()
        Me.GPanelProductos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.prCargando = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.grProductos = New Janus.Windows.GridEX.GridEX()
        Me.pictureImagen = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbPrecio = New DevComponents.Editors.DoubleInput()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tbDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbProducto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.CmDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarCantidadMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProductoMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.grdetalle = New Janus.Windows.GridEX.GridEX()
        Me.PanelButtom = New System.Windows.Forms.Panel()
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.tbTotal = New DevComponents.Editors.DoubleInput()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbNit = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.QrFactura = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.TimerImagenes = New System.Windows.Forms.Timer(Me.components)
        Me.PanelImagen.SuspendLayout()
        Me.PanelRight.SuspendLayout()
        Me.PanelC.SuspendLayout()
        Me.GPanelProductos.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.grProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.tbPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.CmDetalle.SuspendLayout()
        Me.PanelDatos.SuspendLayout()
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButtom.SuspendLayout()
        Me.PanelTotal.SuspendLayout()
        CType(Me.tbTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelImagen
        '
        Me.PanelImagen.Controls.Add(Me.PanelRight)
        Me.PanelImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelImagen.Location = New System.Drawing.Point(631, 0)
        Me.PanelImagen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelImagen.Name = "PanelImagen"
        Me.PanelImagen.Size = New System.Drawing.Size(525, 594)
        Me.PanelImagen.TabIndex = 1
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.PanelC)
        Me.PanelRight.Controls.Add(Me.Panel2)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Location = New System.Drawing.Point(0, 0)
        Me.PanelRight.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(525, 594)
        Me.PanelRight.TabIndex = 5
        '
        'PanelC
        '
        Me.PanelC.Controls.Add(Me.GPanelProductos)
        Me.PanelC.Controls.Add(Me.pictureImagen)
        Me.PanelC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelC.Location = New System.Drawing.Point(0, 154)
        Me.PanelC.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelC.Name = "PanelC"
        Me.PanelC.Size = New System.Drawing.Size(525, 440)
        Me.PanelC.TabIndex = 1
        '
        'GPanelProductos
        '
        Me.GPanelProductos.BackColor = System.Drawing.Color.Black
        Me.GPanelProductos.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPanelProductos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPanelProductos.Controls.Add(Me.Panel5)
        Me.GPanelProductos.DisabledBackColor = System.Drawing.Color.Empty
        Me.GPanelProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GPanelProductos.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPanelProductos.Location = New System.Drawing.Point(0, 0)
        Me.GPanelProductos.Name = "GPanelProductos"
        Me.GPanelProductos.Size = New System.Drawing.Size(525, 440)
        '
        '
        '
        Me.GPanelProductos.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GPanelProductos.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GPanelProductos.Style.BackColorGradientAngle = 90
        Me.GPanelProductos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderBottomWidth = 1
        Me.GPanelProductos.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GPanelProductos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderLeftWidth = 1
        Me.GPanelProductos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderRightWidth = 1
        Me.GPanelProductos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderTopWidth = 1
        Me.GPanelProductos.Style.CornerDiameter = 4
        Me.GPanelProductos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPanelProductos.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPanelProductos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPanelProductos.Style.TextColor = System.Drawing.Color.White
        Me.GPanelProductos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPanelProductos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPanelProductos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPanelProductos.TabIndex = 4
        Me.GPanelProductos.Text = "PRODUCTOS"
        Me.GPanelProductos.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.prCargando)
        Me.Panel5.Controls.Add(Me.grProductos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(519, 417)
        Me.Panel5.TabIndex = 0
        '
        'prCargando
        '
        Me.prCargando.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.prCargando.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prCargando.Font = New System.Drawing.Font("Calibri", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prCargando.Location = New System.Drawing.Point(-3, 11)
        Me.prCargando.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.prCargando.Name = "prCargando"
        Me.prCargando.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.prCargando.ProgressColor = System.Drawing.Color.LimeGreen
        Me.prCargando.ProgressTextColor = System.Drawing.Color.Black
        Me.prCargando.ProgressTextVisible = True
        Me.prCargando.Size = New System.Drawing.Size(431, 208)
        Me.prCargando.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.prCargando.TabIndex = 6
        Me.prCargando.Visible = False
        '
        'grProductos
        '
        Me.grProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grProductos.BackColor = System.Drawing.Color.White
        Me.grProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grProductos.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grProductos.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grProductos.Location = New System.Drawing.Point(0, 0)
        Me.grProductos.Name = "grProductos"
        Me.grProductos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grProductos.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grProductos.Size = New System.Drawing.Size(519, 417)
        Me.grProductos.TabIndex = 0
        Me.grProductos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'pictureImagen
        '
        Me.pictureImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureImagen.Image = Global.DinoM.My.Resources.Resources.FondoMercado
        Me.pictureImagen.Location = New System.Drawing.Point(0, 0)
        Me.pictureImagen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pictureImagen.Name = "pictureImagen"
        Me.pictureImagen.Size = New System.Drawing.Size(525, 440)
        Me.pictureImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureImagen.TabIndex = 0
        Me.pictureImagen.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.DinoM.My.Resources.Resources.fondo1
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8, 16, 8, 12)
        Me.Panel2.Size = New System.Drawing.Size(525, 154)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.tbPrecio)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(8, 16)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(15, 16, 15, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Panel3.Size = New System.Drawing.Size(507, 124)
        Me.Panel3.TabIndex = 5
        '
        'tbPrecio
        '
        Me.tbPrecio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbPrecio.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPrecio.BackgroundStyle.BackColor2 = System.Drawing.Color.White
        Me.tbPrecio.BackgroundStyle.BorderColor = System.Drawing.Color.White
        Me.tbPrecio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbPrecio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPrecio.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.tbPrecio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbPrecio.Font = New System.Drawing.Font("Calibri", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrecio.ForeColor = System.Drawing.Color.Black
        Me.tbPrecio.Increment = 1.0R
        Me.tbPrecio.IsInputReadOnly = True
        Me.tbPrecio.Location = New System.Drawing.Point(153, 72)
        Me.tbPrecio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(205, 53)
        Me.tbPrecio.TabIndex = 4
        Me.tbPrecio.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tbDescripcion)
        Me.Panel4.Controls.Add(Me.tbProducto)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(507, 63)
        Me.Panel4.TabIndex = 5
        '
        'tbDescripcion
        '
        Me.tbDescripcion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbDescripcion.Border.BackColor = System.Drawing.Color.White
        Me.tbDescripcion.Border.BackColor2 = System.Drawing.Color.White
        Me.tbDescripcion.Border.BorderColor = System.Drawing.Color.White
        Me.tbDescripcion.Border.Class = "ItemPanel"
        Me.tbDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.tbDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDescripcion.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbDescripcion.Location = New System.Drawing.Point(224, 0)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(283, 53)
        Me.tbDescripcion.TabIndex = 4
        '
        'tbProducto
        '
        Me.tbProducto.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbProducto.Border.BackColor = System.Drawing.Color.White
        Me.tbProducto.Border.BackColor2 = System.Drawing.Color.White
        Me.tbProducto.Border.BorderColor = System.Drawing.Color.White
        Me.tbProducto.Border.Class = "ItemPanel"
        Me.tbProducto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.tbProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.tbProducto.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbProducto.Location = New System.Drawing.Point(0, 0)
        Me.tbProducto.Name = "tbProducto"
        Me.tbProducto.Size = New System.Drawing.Size(224, 53)
        Me.tbProducto.TabIndex = 3
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'CmDetalle
        '
        Me.CmDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarCantidadMenu, Me.EliminarProductoMenu})
        Me.CmDetalle.Name = "CmDetalle"
        Me.CmDetalle.Size = New System.Drawing.Size(191, 76)
        '
        'ModificarCantidadMenu
        '
        Me.ModificarCantidadMenu.Image = Global.DinoM.My.Resources.Resources.edit2
        Me.ModificarCantidadMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ModificarCantidadMenu.Name = "ModificarCantidadMenu"
        Me.ModificarCantidadMenu.Size = New System.Drawing.Size(190, 36)
        Me.ModificarCantidadMenu.Text = "Modificar Cantidad"
        '
        'EliminarProductoMenu
        '
        Me.EliminarProductoMenu.Image = Global.DinoM.My.Resources.Resources._051_prohibition
        Me.EliminarProductoMenu.Name = "EliminarProductoMenu"
        Me.EliminarProductoMenu.Size = New System.Drawing.Size(190, 36)
        Me.EliminarProductoMenu.Text = "Eliminar Producto"
        '
        'PanelDatos
        '
        Me.PanelDatos.BackgroundImage = Global.DinoM.My.Resources.Resources.fondo1
        Me.PanelDatos.Controls.Add(Me.grdetalle)
        Me.PanelDatos.Controls.Add(Me.PanelButtom)
        Me.PanelDatos.Controls.Add(Me.PanelTop)
        Me.PanelDatos.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDatos.Location = New System.Drawing.Point(0, 0)
        Me.PanelDatos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PanelDatos.Size = New System.Drawing.Size(631, 594)
        Me.PanelDatos.TabIndex = 0
        '
        'grdetalle
        '
        Me.grdetalle.BackColor = System.Drawing.Color.White
        Me.grdetalle.ColumnAutoResize = True
        Me.grdetalle.ContextMenuStrip = Me.CmDetalle
        Me.grdetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdetalle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdetalle.GridLineColor = System.Drawing.Color.White
        Me.grdetalle.GridLines = Janus.Windows.GridEX.GridLines.None
        Me.grdetalle.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grdetalle.HeaderFormatStyle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdetalle.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.grdetalle.Location = New System.Drawing.Point(6, 160)
        Me.grdetalle.Name = "grdetalle"
        Me.grdetalle.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grdetalle.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grdetalle.RowFormatStyle.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdetalle.Size = New System.Drawing.Size(619, 291)
        Me.grdetalle.TabIndex = 4
        Me.grdetalle.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'PanelButtom
        '
        Me.PanelButtom.BackColor = System.Drawing.Color.White
        Me.PanelButtom.Controls.Add(Me.PanelTotal)
        Me.PanelButtom.Controls.Add(Me.Panel1)
        Me.PanelButtom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelButtom.Location = New System.Drawing.Point(6, 451)
        Me.PanelButtom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelButtom.Name = "PanelButtom"
        Me.PanelButtom.Size = New System.Drawing.Size(619, 137)
        Me.PanelButtom.TabIndex = 5
        '
        'PanelTotal
        '
        Me.PanelTotal.BackColor = System.Drawing.SystemColors.Desktop
        Me.PanelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTotal.Controls.Add(Me.tbTotal)
        Me.PanelTotal.Controls.Add(Me.Label2)
        Me.PanelTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTotal.Location = New System.Drawing.Point(0, -1)
        Me.PanelTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(619, 82)
        Me.PanelTotal.TabIndex = 0
        '
        'tbTotal
        '
        '
        '
        '
        Me.tbTotal.BackgroundStyle.BackColor = System.Drawing.Color.Black
        Me.tbTotal.BackgroundStyle.BackColor2 = System.Drawing.Color.Black
        Me.tbTotal.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.tbTotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbTotal.Font = New System.Drawing.Font("Calibri", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.ForeColor = System.Drawing.Color.White
        Me.tbTotal.Increment = 1.0R
        Me.tbTotal.IsInputReadOnly = True
        Me.tbTotal.Location = New System.Drawing.Point(393, 15)
        Me.tbTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(207, 53)
        Me.tbTotal.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Bs:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbNit)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbCliente)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbFecha)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 56)
        Me.Panel1.TabIndex = 9
        '
        'lbNit
        '
        Me.lbNit.AutoSize = True
        Me.lbNit.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNit.Location = New System.Drawing.Point(65, 31)
        Me.lbNit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNit.Name = "lbNit"
        Me.lbNit.Size = New System.Drawing.Size(62, 13)
        Me.lbNit.TabIndex = 6
        Me.lbNit.Text = "8230749 SC"
        Me.lbNit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Nit:"
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCliente.Location = New System.Drawing.Point(65, 17)
        Me.lbCliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(147, 13)
        Me.lbCliente.TabIndex = 4
        Me.lbCliente.Text = "Marco Antonio Mamani Chura"
        Me.lbCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Cliente:"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(65, 3)
        Me.lbFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(63, 13)
        Me.lbFecha.TabIndex = 2
        Me.lbFecha.Text = "30/10/2020"
        Me.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha:"
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.PictureBox2)
        Me.PanelTop.Controls.Add(Me.QrFactura)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(6, 6)
        Me.PanelTop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(619, 154)
        Me.PanelTop.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(619, 154)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'QrFactura
        '
        Me.QrFactura.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrFactura.Image = CType(resources.GetObject("QrFactura.Image"), System.Drawing.Image)
        Me.QrFactura.Location = New System.Drawing.Point(472, 18)
        Me.QrFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.QrFactura.Name = "QrFactura"
        Me.QrFactura.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrFactura.Size = New System.Drawing.Size(50, 53)
        Me.QrFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QrFactura.TabIndex = 23
        Me.QrFactura.TabStop = False
        Me.QrFactura.Text = "QrCodeImgControl1"
        Me.QrFactura.Visible = False
        '
        'TimerImagenes
        '
        Me.TimerImagenes.Interval = 10000
        '
        'F0_VentasSupermercado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 594)
        Me.Controls.Add(Me.PanelImagen)
        Me.Controls.Add(Me.PanelDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "F0_VentasSupermercado"
        Me.Text = "Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelImagen.ResumeLayout(False)
        Me.PanelRight.ResumeLayout(False)
        Me.PanelC.ResumeLayout(False)
        Me.GPanelProductos.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.grProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.tbPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.CmDetalle.ResumeLayout(False)
        Me.PanelDatos.ResumeLayout(False)
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButtom.ResumeLayout(False)
        Me.PanelTotal.ResumeLayout(False)
        Me.PanelTotal.PerformLayout()
        CType(Me.tbTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDatos As Panel
    Friend WithEvents PanelImagen As Panel
    Friend WithEvents pictureImagen As PictureBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents tbProducto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelButtom As Panel
    Friend WithEvents grdetalle As Janus.Windows.GridEX.GridEX
    Friend WithEvents PanelTotal As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbFecha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbCliente As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbNit As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GPanelProductos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents grProductos As Janus.Windows.GridEX.GridEX
    Friend WithEvents QrFactura As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents tbTotal As DevComponents.Editors.DoubleInput
    Friend WithEvents PanelRight As Panel
    Friend WithEvents PanelC As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tbPrecio As DevComponents.Editors.DoubleInput
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tbDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CmDetalle As ContextMenuStrip
    Friend WithEvents ModificarCantidadMenu As ToolStripMenuItem
    Friend WithEvents EliminarProductoMenu As ToolStripMenuItem
    Friend WithEvents prCargando As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents TimerImagenes As Timer
End Class
