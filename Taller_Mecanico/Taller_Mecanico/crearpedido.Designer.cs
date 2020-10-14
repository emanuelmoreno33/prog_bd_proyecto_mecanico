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
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label fecha_registroLabel;
            System.Windows.Forms.Label fecha_entregaLabel;
            System.Windows.Forms.Label id_estadoLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label impuestoLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearpedido));
            this.tallermecanicoDataSet = new Taller_Mecanico.tallermecanicoDataSet();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.pedidoTableAdapter();
            this.tableAdapterManager = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.TableAdapterManager();
            this.pedidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.id_marcaComboBox = new System.Windows.Forms.ComboBox();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.fecha_registroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_entregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.impuestoTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.pedidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            placaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            id_marcaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            fecha_registroLabel = new System.Windows.Forms.Label();
            fecha_entregaLabel = new System.Windows.Forms.Label();
            id_estadoLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            impuestoLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tallermecanicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).BeginInit();
            this.pedidoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.pedidoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pedidoBindingNavigator.BindingSource = this.pedidoBindingSource;
            this.pedidoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pedidoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pedidoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pedidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pedidoBindingNavigatorSaveItem});
            this.pedidoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pedidoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pedidoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pedidoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pedidoBindingNavigator.Name = "pedidoBindingNavigator";
            this.pedidoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pedidoBindingNavigator.Size = new System.Drawing.Size(421, 27);
            this.pedidoBindingNavigator.TabIndex = 0;
            this.pedidoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // placaTextBox
            // 
            this.placaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "placa", true));
            this.placaTextBox.Location = new System.Drawing.Point(140, 49);
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(200, 22);
            this.placaTextBox.TabIndex = 2;
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
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(140, 77);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(200, 22);
            this.modeloTextBox.TabIndex = 4;
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
            // id_marcaComboBox
            // 
            this.id_marcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "id_marca", true));
            this.id_marcaComboBox.FormattingEnabled = true;
            this.id_marcaComboBox.Location = new System.Drawing.Point(140, 105);
            this.id_marcaComboBox.Name = "id_marcaComboBox";
            this.id_marcaComboBox.Size = new System.Drawing.Size(200, 24);
            this.id_marcaComboBox.TabIndex = 6;
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(34, 139);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(68, 17);
            id_clienteLabel.TabIndex = 7;
            id_clienteLabel.Text = "id cliente:";
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(140, 136);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_clienteTextBox.TabIndex = 8;
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
            // fecha_registroDateTimePicker
            // 
            this.fecha_registroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoBindingSource, "fecha_registro", true));
            this.fecha_registroDateTimePicker.Location = new System.Drawing.Point(140, 164);
            this.fecha_registroDateTimePicker.Name = "fecha_registroDateTimePicker";
            this.fecha_registroDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fecha_registroDateTimePicker.TabIndex = 10;
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
            // fecha_entregaDateTimePicker
            // 
            this.fecha_entregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedidoBindingSource, "fecha_entrega", true));
            this.fecha_entregaDateTimePicker.Location = new System.Drawing.Point(140, 192);
            this.fecha_entregaDateTimePicker.Name = "fecha_entregaDateTimePicker";
            this.fecha_entregaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fecha_entregaDateTimePicker.TabIndex = 12;
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
            // id_estadoComboBox
            // 
            this.id_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "id_estado", true));
            this.id_estadoComboBox.FormattingEnabled = true;
            this.id_estadoComboBox.Location = new System.Drawing.Point(140, 220);
            this.id_estadoComboBox.Name = "id_estadoComboBox";
            this.id_estadoComboBox.Size = new System.Drawing.Size(200, 24);
            this.id_estadoComboBox.TabIndex = 14;
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
            // subtotalTextBox
            // 
            this.subtotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "subtotal", true));
            this.subtotalTextBox.Location = new System.Drawing.Point(140, 251);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(200, 22);
            this.subtotalTextBox.TabIndex = 16;
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
            // impuestoTextBox
            // 
            this.impuestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "impuesto", true));
            this.impuestoTextBox.Location = new System.Drawing.Point(140, 279);
            this.impuestoTextBox.Name = "impuestoTextBox";
            this.impuestoTextBox.Size = new System.Drawing.Size(200, 22);
            this.impuestoTextBox.TabIndex = 18;
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
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(140, 307);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(200, 22);
            this.descuentoTextBox.TabIndex = 20;
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
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(140, 335);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 22);
            this.totalTextBox.TabIndex = 22;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // pedidoBindingNavigatorSaveItem
            // 
            this.pedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoBindingNavigatorSaveItem.Image")));
            this.pedidoBindingNavigatorSaveItem.Name = "pedidoBindingNavigatorSaveItem";
            this.pedidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pedidoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pedidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoBindingNavigatorSaveItem_Click);
            // 
            // crearpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 406);
            this.Controls.Add(placaLabel);
            this.Controls.Add(this.placaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(id_marcaLabel);
            this.Controls.Add(this.id_marcaComboBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tallermecanicoDataSet tallermecanicoDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private tallermecanicoDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private tallermecanicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pedidoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.ComboBox id_marcaComboBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.DateTimePicker fecha_registroDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_entregaDateTimePicker;
        private System.Windows.Forms.ComboBox id_estadoComboBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox impuestoTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}