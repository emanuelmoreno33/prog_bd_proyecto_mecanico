namespace Taller_Mecanico
{
    partial class crearpedido
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label placaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label id_marcaLabel;
            System.Windows.Forms.Label fecha_registroLabel;
            System.Windows.Forms.Label fecha_entregaLabel;
            System.Windows.Forms.Label id_estadoLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label impuestoLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearpedido));
            System.Windows.Forms.Label id_clienteLabel;
            this.tallermecanicoDataSet = new Taller_Mecanico.tallermecanicoDataSet();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.pedidoTableAdapter();
            this.tableAdapterManager = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.TableAdapterManager();
            this.pedidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.pedidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.id_marcaComboBox = new System.Windows.Forms.ComboBox();
            this.fecha_registroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_entregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.impuestoTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.marcaTableAdapter();
            this.id_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.clienteTableAdapter();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoTableAdapter = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.estadoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            placaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            id_marcaLabel = new System.Windows.Forms.Label();
            fecha_registroLabel = new System.Windows.Forms.Label();
            fecha_entregaLabel = new System.Windows.Forms.Label();
            id_estadoLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            impuestoLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tallermecanicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).BeginInit();
            this.pedidoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.Location = new System.Drawing.Point(34, 52);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new System.Drawing.Size(46, 17);
            placaLabel.TabIndex = 1;
            placaLabel.Text = "placa:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(34, 80);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(58, 17);
            modeloLabel.TabIndex = 3;
            modeloLabel.Text = "modelo:";
            // 
            // id_marcaLabel
            // 
            id_marcaLabel.AutoSize = true;
            id_marcaLabel.Location = new System.Drawing.Point(34, 108);
            id_marcaLabel.Name = "id_marcaLabel";
            id_marcaLabel.Size = new System.Drawing.Size(66, 17);
            id_marcaLabel.TabIndex = 5;
            id_marcaLabel.Text = "id marca:";
            // 
            // fecha_registroLabel
            // 
            fecha_registroLabel.AutoSize = true;
            fecha_registroLabel.Location = new System.Drawing.Point(34, 168);
            fecha_registroLabel.Name = "fecha_registroLabel";
            fecha_registroLabel.Size = new System.Drawing.Size(99, 17);
            fecha_registroLabel.TabIndex = 9;
            fecha_registroLabel.Text = "fecha registro:";
            // 
            // fecha_entregaLabel
            // 
            fecha_entregaLabel.AutoSize = true;
            fecha_entregaLabel.Location = new System.Drawing.Point(34, 196);
            fecha_entregaLabel.Name = "fecha_entregaLabel";
            fecha_entregaLabel.Size = new System.Drawing.Size(100, 17);
            fecha_entregaLabel.TabIndex = 11;
            fecha_entregaLabel.Text = "fecha entrega:";
            // 
            // id_estadoLabel
            // 
            id_estadoLabel.AutoSize = true;
            id_estadoLabel.Location = new System.Drawing.Point(34, 223);
            id_estadoLabel.Name = "id_estadoLabel";
            id_estadoLabel.Size = new System.Drawing.Size(70, 17);
            id_estadoLabel.TabIndex = 13;
            id_estadoLabel.Text = "id estado:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(34, 254);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(62, 17);
            subtotalLabel.TabIndex = 15;
            subtotalLabel.Text = "subtotal:";
            // 
            // impuestoLabel
            // 
            impuestoLabel.AutoSize = true;
            impuestoLabel.Location = new System.Drawing.Point(34, 282);
            impuestoLabel.Name = "impuestoLabel";
            impuestoLabel.Size = new System.Drawing.Size(69, 17);
            impuestoLabel.TabIndex = 17;
            impuestoLabel.Text = "impuesto:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(34, 310);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(78, 17);
            descuentoLabel.TabIndex = 19;
            descuentoLabel.Text = "descuento:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(34, 338);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(39, 17);
            totalLabel.TabIndex = 21;
            totalLabel.Text = "total:";
            // 
            // tallermecanicoDataSet
            // 
            this.tallermecanicoDataSet.DataSetName = "tallermecanicoDataSet";
            this.tallermecanicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.tallermecanicoDataSet;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compra_insumoTableAdapter = null;
            this.tableAdapterManager.departamentoTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.garantiaTableAdapter = null;
            this.tableAdapterManager.insumoTableAdapter = null;
            this.tableAdapterManager.marcaTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = this.pedidoTableAdapter;
            this.tableAdapterManager.proveedor_insumoTableAdapter = null;
            this.tableAdapterManager.proveedorTableAdapter = null;
            this.tableAdapterManager.servicioTableAdapter = null;
            this.tableAdapterManager.tipo_insumoTableAdapter = null;
            this.tableAdapterManager.tipo_servicioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Taller_Mecanico.tallermecanicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // pedidoBindingNavigator
            // 
            this.pedidoBindingNavigator.AddNewItem = null;
            this.pedidoBindingNavigator.BindingSource = this.pedidoBindingSource;
            this.pedidoBindingNavigator.CountItem = null;
            this.pedidoBindingNavigator.DeleteItem = null;
            this.pedidoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pedidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.pedidoBindingNavigatorSaveItem});
            this.pedidoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoBindingNavigator.MoveFirstItem = null;
            this.pedidoBindingNavigator.MoveLastItem = null;
            this.pedidoBindingNavigator.MoveNextItem = null;
            this.pedidoBindingNavigator.MovePreviousItem = null;
            this.pedidoBindingNavigator.Name = "pedidoBindingNavigator";
            this.pedidoBindingNavigator.PositionItem = null;
            this.pedidoBindingNavigator.Size = new System.Drawing.Size(507, 31);
            this.pedidoBindingNavigator.TabIndex = 0;
            this.pedidoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // pedidoBindingNavigatorSaveItem
            // 
            this.pedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoBindingNavigatorSaveItem.Image")));
            this.pedidoBindingNavigatorSaveItem.Name = "pedidoBindingNavigatorSaveItem";
            this.pedidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.pedidoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pedidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoBindingNavigatorSaveItem_Click);
            // 
            // placaTextBox
            // 
            this.placaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "placa", true));
            this.placaTextBox.Location = new System.Drawing.Point(140, 49);
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(200, 22);
            this.placaTextBox.TabIndex = 2;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(140, 77);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(200, 22);
            this.modeloTextBox.TabIndex = 4;
            // 
            // id_marcaComboBox
            // 
            this.id_marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "id_marca", true));
            this.id_marcaComboBox.DataSource = this.marcaBindingSource;
            this.id_marcaComboBox.DisplayMember = "descripcion";
            this.id_marcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_marcaComboBox.FormattingEnabled = true;
            this.id_marcaComboBox.Location = new System.Drawing.Point(140, 105);
            this.id_marcaComboBox.Name = "id_marcaComboBox";
            this.id_marcaComboBox.Size = new System.Drawing.Size(200, 24);
            this.id_marcaComboBox.TabIndex = 6;
            this.id_marcaComboBox.ValueMember = "id_marca";
            // 
            // fecha_registroDateTimePicker
            // 
            this.fecha_registroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoBindingSource, "fecha_registro", true));
            this.fecha_registroDateTimePicker.Location = new System.Drawing.Point(140, 164);
            this.fecha_registroDateTimePicker.Name = "fecha_registroDateTimePicker";
            this.fecha_registroDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fecha_registroDateTimePicker.TabIndex = 10;
            // 
            // fecha_entregaDateTimePicker
            // 
            this.fecha_entregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoBindingSource, "fecha_entrega", true));
            this.fecha_entregaDateTimePicker.Location = new System.Drawing.Point(140, 192);
            this.fecha_entregaDateTimePicker.Name = "fecha_entregaDateTimePicker";
            this.fecha_entregaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fecha_entregaDateTimePicker.TabIndex = 12;
            // 
            // id_estadoComboBox
            // 
            this.id_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "id_estado", true));
            this.id_estadoComboBox.DataSource = this.estadoBindingSource;
            this.id_estadoComboBox.DisplayMember = "descripcion";
            this.id_estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_estadoComboBox.FormattingEnabled = true;
            this.id_estadoComboBox.Location = new System.Drawing.Point(140, 220);
            this.id_estadoComboBox.Name = "id_estadoComboBox";
            this.id_estadoComboBox.Size = new System.Drawing.Size(200, 24);
            this.id_estadoComboBox.TabIndex = 14;
            this.id_estadoComboBox.ValueMember = "id_estado";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "subtotal", true));
            this.subtotalTextBox.Location = new System.Drawing.Point(140, 251);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(200, 22);
            this.subtotalTextBox.TabIndex = 16;
            // 
            // impuestoTextBox
            // 
            this.impuestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "impuesto", true));
            this.impuestoTextBox.Location = new System.Drawing.Point(140, 279);
            this.impuestoTextBox.Name = "impuestoTextBox";
            this.impuestoTextBox.Size = new System.Drawing.Size(200, 22);
            this.impuestoTextBox.TabIndex = 18;
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(140, 307);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(200, 22);
            this.descuentoTextBox.TabIndex = 20;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(140, 335);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(200, 22);
            this.totalTextBox.TabIndex = 22;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "marca";
            this.marcaBindingSource.DataSource = this.tallermecanicoDataSet;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(36, 137);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(68, 17);
            id_clienteLabel.TabIndex = 22;
            id_clienteLabel.Text = "id cliente:";
            // 
            // id_clienteComboBox
            // 
            this.id_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "id_cliente", true));
            this.id_clienteComboBox.DataSource = this.clienteBindingSource;
            this.id_clienteComboBox.DisplayMember = "nombre";
            this.id_clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_clienteComboBox.FormattingEnabled = true;
            this.id_clienteComboBox.Location = new System.Drawing.Point(140, 134);
            this.id_clienteComboBox.Name = "id_clienteComboBox";
            this.id_clienteComboBox.Size = new System.Drawing.Size(200, 24);
            this.id_clienteComboBox.TabIndex = 23;
            this.id_clienteComboBox.ValueMember = "id_cliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.tallermecanicoDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "estado";
            this.estadoBindingSource.DataSource = this.tallermecanicoDataSet;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Calcular total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crearpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteComboBox);
            this.Controls.Add(placaLabel);
            this.Controls.Add(this.placaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(id_marcaLabel);
            this.Controls.Add(this.id_marcaComboBox);
            this.Controls.Add(fecha_registroLabel);
            this.Controls.Add(this.fecha_registroDateTimePicker);
            this.Controls.Add(fecha_entregaLabel);
            this.Controls.Add(this.fecha_entregaDateTimePicker);
            this.Controls.Add(id_estadoLabel);
            this.Controls.Add(this.id_estadoComboBox);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(impuestoLabel);
            this.Controls.Add(this.impuestoTextBox);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.pedidoBindingNavigator);
            this.Name = "crearpedido";
            this.Text = "crearpedido";
            this.Load += new System.EventHandler(this.crearpedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tallermecanicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).EndInit();
            this.pedidoBindingNavigator.ResumeLayout(false);
            this.pedidoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tallermecanicoDataSet tallermecanicoDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private tallermecanicoDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private tallermecanicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton pedidoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.ComboBox id_marcaComboBox;
        private System.Windows.Forms.DateTimePicker fecha_registroDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_entregaDateTimePicker;
        private System.Windows.Forms.ComboBox id_estadoComboBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox impuestoTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private tallermecanicoDataSetTableAdapters.marcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.ComboBox id_clienteComboBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private tallermecanicoDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private tallermecanicoDataSetTableAdapters.estadoTableAdapter estadoTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}