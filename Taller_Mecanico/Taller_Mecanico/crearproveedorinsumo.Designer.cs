namespace Taller_Mecanico
{
    partial class crearproveedorinsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearproveedorinsumo));
            this.tallermecanicoDataSet = new Taller_Mecanico.tallermecanicoDataSet();
            this.proveedor_insumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedor_insumoTableAdapter = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.proveedor_insumoTableAdapter();
            this.tableAdapterManager = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.TableAdapterManager();
            this.proveedor_insumoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.proveedor_insumoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.proveedor_insumoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tallermecanicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_insumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_insumoBindingNavigator)).BeginInit();
            this.proveedor_insumoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_insumoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tallermecanicoDataSet
            // 
            this.tallermecanicoDataSet.DataSetName = "tallermecanicoDataSet";
            this.tallermecanicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedor_insumoBindingSource
            // 
            this.proveedor_insumoBindingSource.DataMember = "proveedor_insumo";
            this.proveedor_insumoBindingSource.DataSource = this.tallermecanicoDataSet;
            // 
            // proveedor_insumoTableAdapter
            // 
            this.proveedor_insumoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.proveedor_insumoTableAdapter = this.proveedor_insumoTableAdapter;
            this.tableAdapterManager.proveedorTableAdapter = null;
            this.tableAdapterManager.servicioTableAdapter = null;
            this.tableAdapterManager.tipo_insumoTableAdapter = null;
            this.tableAdapterManager.tipo_servicioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Taller_Mecanico.tallermecanicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // proveedor_insumoBindingNavigator
            // 
            this.proveedor_insumoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proveedor_insumoBindingNavigator.BindingSource = this.proveedor_insumoBindingSource;
            this.proveedor_insumoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proveedor_insumoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proveedor_insumoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.proveedor_insumoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.proveedor_insumoBindingNavigatorSaveItem});
            this.proveedor_insumoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proveedor_insumoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proveedor_insumoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proveedor_insumoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proveedor_insumoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proveedor_insumoBindingNavigator.Name = "proveedor_insumoBindingNavigator";
            this.proveedor_insumoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proveedor_insumoBindingNavigator.Size = new System.Drawing.Size(971, 27);
            this.proveedor_insumoBindingNavigator.TabIndex = 0;
            this.proveedor_insumoBindingNavigator.Text = "bindingNavigator1";
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
            // proveedor_insumoDataGridView
            // 
            this.proveedor_insumoDataGridView.AutoGenerateColumns = false;
            this.proveedor_insumoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedor_insumoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.proveedor_insumoDataGridView.DataSource = this.proveedor_insumoBindingSource;
            this.proveedor_insumoDataGridView.Location = new System.Drawing.Point(12, 49);
            this.proveedor_insumoDataGridView.Name = "proveedor_insumoDataGridView";
            this.proveedor_insumoDataGridView.RowHeadersWidth = 51;
            this.proveedor_insumoDataGridView.RowTemplate.Height = 24;
            this.proveedor_insumoDataGridView.Size = new System.Drawing.Size(953, 287);
            this.proveedor_insumoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor_insumo";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_proveedor_insumo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_proveedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_proveedor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_insumo";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_insumo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "creado_por";
            this.dataGridViewTextBoxColumn4.HeaderText = "creado_por";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_creado";
            this.dataGridViewTextBoxColumn5.HeaderText = "fecha_creado";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "modificado_por";
            this.dataGridViewTextBoxColumn6.HeaderText = "modificado_por";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_modificado";
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha_modificado";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
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
            // proveedor_insumoBindingNavigatorSaveItem
            // 
            this.proveedor_insumoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proveedor_insumoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedor_insumoBindingNavigatorSaveItem.Image")));
            this.proveedor_insumoBindingNavigatorSaveItem.Name = "proveedor_insumoBindingNavigatorSaveItem";
            this.proveedor_insumoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.proveedor_insumoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.proveedor_insumoBindingNavigatorSaveItem.Click += new System.EventHandler(this.proveedor_insumoBindingNavigatorSaveItem_Click);
            // 
            // crearproveedorinsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 368);
            this.Controls.Add(this.proveedor_insumoDataGridView);
            this.Controls.Add(this.proveedor_insumoBindingNavigator);
            this.Name = "crearproveedorinsumo";
            this.Text = "crearproveedorinsumo";
            this.Load += new System.EventHandler(this.crearproveedorinsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tallermecanicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_insumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_insumoBindingNavigator)).EndInit();
            this.proveedor_insumoBindingNavigator.ResumeLayout(false);
            this.proveedor_insumoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedor_insumoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tallermecanicoDataSet tallermecanicoDataSet;
        private System.Windows.Forms.BindingSource proveedor_insumoBindingSource;
        private tallermecanicoDataSetTableAdapters.proveedor_insumoTableAdapter proveedor_insumoTableAdapter;
        private tallermecanicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proveedor_insumoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton proveedor_insumoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView proveedor_insumoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}