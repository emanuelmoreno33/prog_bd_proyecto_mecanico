namespace Taller_Mecanico
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarInsumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasPedidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteConMayorFrecuenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasObtenidasDeDiagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoConMayorVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparacionesMasConcurrentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoConMasAfluenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumoDeRefaccionesPorDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caracteristicasDeLosAutomovilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteConMayorGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refaccionMasVendidaYSuGananciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadorConMasGarantiasAplicadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prooveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasDeAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.letrerousuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.agregarProveedorInsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRefaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.insumosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPedidosToolStripMenuItem,
            this.editarPedidosToolStripMenuItem,
            this.agregarRefaccionesToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // crearPedidosToolStripMenuItem
            // 
            this.crearPedidosToolStripMenuItem.Name = "crearPedidosToolStripMenuItem";
            this.crearPedidosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.crearPedidosToolStripMenuItem.Text = "Crear pedidos";
            this.crearPedidosToolStripMenuItem.Click += new System.EventHandler(this.crearPedidosToolStripMenuItem_Click);
            // 
            // editarPedidosToolStripMenuItem
            // 
            this.editarPedidosToolStripMenuItem.Name = "editarPedidosToolStripMenuItem";
            this.editarPedidosToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.editarPedidosToolStripMenuItem.Text = "Agregar servicios";
            this.editarPedidosToolStripMenuItem.Click += new System.EventHandler(this.editarPedidosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregaClientesToolStripMenuItem
            // 
            this.agregaClientesToolStripMenuItem.Name = "agregaClientesToolStripMenuItem";
            this.agregaClientesToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.agregaClientesToolStripMenuItem.Text = "Agrega clientes";
            this.agregaClientesToolStripMenuItem.Click += new System.EventHandler(this.agregaClientesToolStripMenuItem_Click);
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarInsumosToolStripMenuItem,
            this.agregarProveedorInsumoToolStripMenuItem});
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.insumosToolStripMenuItem.Text = "Insumos";
            // 
            // agregarInsumosToolStripMenuItem
            // 
            this.agregarInsumosToolStripMenuItem.Name = "agregarInsumosToolStripMenuItem";
            this.agregarInsumosToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.agregarInsumosToolStripMenuItem.Text = "Agregar insumos";
            this.agregarInsumosToolStripMenuItem.Click += new System.EventHandler(this.agregarInsumosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasPedidasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultasPedidasToolStripMenuItem
            // 
            this.consultasPedidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteConMayorFrecuenciaToolStripMenuItem,
            this.ventasObtenidasDeDiagnosticoToolStripMenuItem,
            this.empleadoConMayorVentaToolStripMenuItem,
            this.reparacionesMasConcurrentesToolStripMenuItem,
            this.departamentoConMasAfluenciaToolStripMenuItem,
            this.consumoDeRefaccionesPorDepartamentoToolStripMenuItem,
            this.caracteristicasDeLosAutomovilesToolStripMenuItem,
            this.clienteConMayorGastoToolStripMenuItem,
            this.refaccionMasVendidaYSuGananciaToolStripMenuItem,
            this.trabajadorConMasGarantiasAplicadasToolStripMenuItem});
            this.consultasPedidasToolStripMenuItem.Name = "consultasPedidasToolStripMenuItem";
            this.consultasPedidasToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.consultasPedidasToolStripMenuItem.Text = "Consultas pedidas";
            // 
            // clienteConMayorFrecuenciaToolStripMenuItem
            // 
            this.clienteConMayorFrecuenciaToolStripMenuItem.Name = "clienteConMayorFrecuenciaToolStripMenuItem";
            this.clienteConMayorFrecuenciaToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.clienteConMayorFrecuenciaToolStripMenuItem.Text = "Cliente con mayor frecuencia";
            this.clienteConMayorFrecuenciaToolStripMenuItem.Click += new System.EventHandler(this.clienteConMayorFrecuenciaToolStripMenuItem_Click);
            // 
            // ventasObtenidasDeDiagnosticoToolStripMenuItem
            // 
            this.ventasObtenidasDeDiagnosticoToolStripMenuItem.Name = "ventasObtenidasDeDiagnosticoToolStripMenuItem";
            this.ventasObtenidasDeDiagnosticoToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.ventasObtenidasDeDiagnosticoToolStripMenuItem.Text = "Ventas obtenidas de diagnostico";
            this.ventasObtenidasDeDiagnosticoToolStripMenuItem.Click += new System.EventHandler(this.ventasObtenidasDeDiagnosticoToolStripMenuItem_Click);
            // 
            // empleadoConMayorVentaToolStripMenuItem
            // 
            this.empleadoConMayorVentaToolStripMenuItem.Name = "empleadoConMayorVentaToolStripMenuItem";
            this.empleadoConMayorVentaToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.empleadoConMayorVentaToolStripMenuItem.Text = "Empleado con mayor venta";
            this.empleadoConMayorVentaToolStripMenuItem.Click += new System.EventHandler(this.empleadoConMayorVentaToolStripMenuItem_Click);
            // 
            // reparacionesMasConcurrentesToolStripMenuItem
            // 
            this.reparacionesMasConcurrentesToolStripMenuItem.Name = "reparacionesMasConcurrentesToolStripMenuItem";
            this.reparacionesMasConcurrentesToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.reparacionesMasConcurrentesToolStripMenuItem.Text = "Reparaciones mas concurrentes";
            this.reparacionesMasConcurrentesToolStripMenuItem.Click += new System.EventHandler(this.reparacionesMasConcurrentesToolStripMenuItem_Click);
            // 
            // departamentoConMasAfluenciaToolStripMenuItem
            // 
            this.departamentoConMasAfluenciaToolStripMenuItem.Name = "departamentoConMasAfluenciaToolStripMenuItem";
            this.departamentoConMasAfluenciaToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.departamentoConMasAfluenciaToolStripMenuItem.Text = "Departamento con mas afluencia";
            this.departamentoConMasAfluenciaToolStripMenuItem.Click += new System.EventHandler(this.departamentoConMasAfluenciaToolStripMenuItem_Click);
            // 
            // consumoDeRefaccionesPorDepartamentoToolStripMenuItem
            // 
            this.consumoDeRefaccionesPorDepartamentoToolStripMenuItem.Name = "consumoDeRefaccionesPorDepartamentoToolStripMenuItem";
            this.consumoDeRefaccionesPorDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.consumoDeRefaccionesPorDepartamentoToolStripMenuItem.Text = "Consumo de refacciones por departamento";
            this.consumoDeRefaccionesPorDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.consumoDeRefaccionesPorDepartamentoToolStripMenuItem_Click);
            // 
            // caracteristicasDeLosAutomovilesToolStripMenuItem
            // 
            this.caracteristicasDeLosAutomovilesToolStripMenuItem.Name = "caracteristicasDeLosAutomovilesToolStripMenuItem";
            this.caracteristicasDeLosAutomovilesToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.caracteristicasDeLosAutomovilesToolStripMenuItem.Text = "Caracteristicas de los automoviles";
            this.caracteristicasDeLosAutomovilesToolStripMenuItem.Click += new System.EventHandler(this.caracteristicasDeLosAutomovilesToolStripMenuItem_Click);
            // 
            // clienteConMayorGastoToolStripMenuItem
            // 
            this.clienteConMayorGastoToolStripMenuItem.Name = "clienteConMayorGastoToolStripMenuItem";
            this.clienteConMayorGastoToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.clienteConMayorGastoToolStripMenuItem.Text = "Cliente con mayor gasto";
            this.clienteConMayorGastoToolStripMenuItem.Click += new System.EventHandler(this.clienteConMayorGastoToolStripMenuItem_Click);
            // 
            // refaccionMasVendidaYSuGananciaToolStripMenuItem
            // 
            this.refaccionMasVendidaYSuGananciaToolStripMenuItem.Name = "refaccionMasVendidaYSuGananciaToolStripMenuItem";
            this.refaccionMasVendidaYSuGananciaToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.refaccionMasVendidaYSuGananciaToolStripMenuItem.Text = "Refaccion mas vendida y su ganancia";
            this.refaccionMasVendidaYSuGananciaToolStripMenuItem.Click += new System.EventHandler(this.refaccionMasVendidaYSuGananciaToolStripMenuItem_Click);
            // 
            // trabajadorConMasGarantiasAplicadasToolStripMenuItem
            // 
            this.trabajadorConMasGarantiasAplicadasToolStripMenuItem.Name = "trabajadorConMasGarantiasAplicadasToolStripMenuItem";
            this.trabajadorConMasGarantiasAplicadasToolStripMenuItem.Size = new System.Drawing.Size(380, 26);
            this.trabajadorConMasGarantiasAplicadasToolStripMenuItem.Text = "Trabajador con mas garantias aplicadas";
            this.trabajadorConMasGarantiasAplicadasToolStripMenuItem.Click += new System.EventHandler(this.trabajadorConMasGarantiasAplicadasToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prooveedoresToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.marcasDeAutoToolStripMenuItem,
            this.servicioToolStripMenuItem1});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // prooveedoresToolStripMenuItem
            // 
            this.prooveedoresToolStripMenuItem.Name = "prooveedoresToolStripMenuItem";
            this.prooveedoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prooveedoresToolStripMenuItem.Text = "Prooveedores";
            this.prooveedoresToolStripMenuItem.Click += new System.EventHandler(this.prooveedoresToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // marcasDeAutoToolStripMenuItem
            // 
            this.marcasDeAutoToolStripMenuItem.Name = "marcasDeAutoToolStripMenuItem";
            this.marcasDeAutoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.marcasDeAutoToolStripMenuItem.Text = "Marcas de auto";
            this.marcasDeAutoToolStripMenuItem.Click += new System.EventHandler(this.marcasDeAutoToolStripMenuItem_Click);
            // 
            // servicioToolStripMenuItem1
            // 
            this.servicioToolStripMenuItem1.Name = "servicioToolStripMenuItem1";
            this.servicioToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.servicioToolStripMenuItem1.Text = "Servicio";
            this.servicioToolStripMenuItem1.Click += new System.EventHandler(this.servicioToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letrerousuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(935, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // letrerousuario
            // 
            this.letrerousuario.Name = "letrerousuario";
            this.letrerousuario.Size = new System.Drawing.Size(62, 20);
            this.letrerousuario.Text = "Usuario:";
            // 
            // agregarProveedorInsumoToolStripMenuItem
            // 
            this.agregarProveedorInsumoToolStripMenuItem.Name = "agregarProveedorInsumoToolStripMenuItem";
            this.agregarProveedorInsumoToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.agregarProveedorInsumoToolStripMenuItem.Text = "Agregar proveedor insumo";
            this.agregarProveedorInsumoToolStripMenuItem.Click += new System.EventHandler(this.agregarProveedorInsumoToolStripMenuItem_Click);
            // 
            // agregarRefaccionesToolStripMenuItem
            // 
            this.agregarRefaccionesToolStripMenuItem.Name = "agregarRefaccionesToolStripMenuItem";
            this.agregarRefaccionesToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.agregarRefaccionesToolStripMenuItem.Text = "Agregar refacciones";
            this.agregarRefaccionesToolStripMenuItem.Click += new System.EventHandler(this.agregarRefaccionesToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 569);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Sistema del taller Doryo";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel letrerousuario;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarInsumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasPedidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prooveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasDeAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteConMayorFrecuenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasObtenidasDeDiagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoConMayorVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparacionesMasConcurrentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoConMasAfluenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumoDeRefaccionesPorDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caracteristicasDeLosAutomovilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteConMayorGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refaccionMasVendidaYSuGananciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadorConMasGarantiasAplicadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedorInsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRefaccionesToolStripMenuItem;
    }
}