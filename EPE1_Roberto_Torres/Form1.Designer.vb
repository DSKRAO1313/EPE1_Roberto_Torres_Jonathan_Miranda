<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCargar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DetalleProducto = New Label()
        precio = New Label()
        producto = New Label()
        cmbProductos = New ComboBox()
        txtDescripcion = New TextBox()
        txtPrecio = New TextBox()
        txtStock = New TextBox()
        SuspendLayout()
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(199, 64)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(193, 23)
        btnCargar.TabIndex = 0
        btnCargar.Text = "Cargar Productos"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 15)
        Label1.TabIndex = 1
        Label1.Text = "Boton de Carga C.Box"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 15)
        Label2.TabIndex = 2
        Label2.Text = "Selecc. Cod. Producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 253)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 3
        Label3.Text = "Detalle Producto:"
        ' 
        ' DetalleProducto
        ' 
        DetalleProducto.AutoSize = True
        DetalleProducto.Location = New Point(59, 308)
        DetalleProducto.Name = "DetalleProducto"
        DetalleProducto.Size = New Size(122, 15)
        DetalleProducto.TabIndex = 4
        DetalleProducto.Text = "Nombre del Producto"
        ' 
        ' precio
        ' 
        precio.AutoSize = True
        precio.Location = New Point(235, 308)
        precio.Name = "precio"
        precio.Size = New Size(111, 15)
        precio.TabIndex = 5
        precio.Text = "Precio del Producto"
        ' 
        ' producto
        ' 
        producto.AutoSize = True
        producto.Location = New Point(388, 308)
        producto.Name = "producto"
        producto.Size = New Size(107, 15)
        producto.TabIndex = 6
        producto.Text = "Stock del Producto"
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(199, 122)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(230, 23)
        cmbProductos.TabIndex = 7
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(24, 344)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.ReadOnly = True
        txtDescripcion.Size = New Size(169, 23)
        txtDescripcion.TabIndex = 8
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(235, 344)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.ReadOnly = True
        txtPrecio.Size = New Size(129, 23)
        txtPrecio.TabIndex = 9
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(388, 344)
        txtStock.Name = "txtStock"
        txtStock.ReadOnly = True
        txtStock.Size = New Size(149, 23)
        txtStock.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(586, 450)
        Controls.Add(txtStock)
        Controls.Add(txtPrecio)
        Controls.Add(txtDescripcion)
        Controls.Add(cmbProductos)
        Controls.Add(producto)
        Controls.Add(precio)
        Controls.Add(DetalleProducto)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCargar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCargar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DetalleProducto As Label
    Friend WithEvents precio As Label
    Friend WithEvents producto As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtStock As TextBox

End Class
