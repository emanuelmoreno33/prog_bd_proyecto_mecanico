namespace Taller_Mecanico
{
    partial class crearprooveedor
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label rfcLabel;
            System.Windows.Forms.Label horario_aperturaLabel;
            System.Windows.Forms.Label horario_cierreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearprooveedor));
            this.tallermecanicoDataSet = new Taller_Mecanico.tallermecanicoDataSet();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.proveedorTableAdapter();
            this.tableAdapterManager = new Taller_Mecanico.tallermecanicoDataSetTableAdapters.TableAdapterManager();
            this.proveedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.proveedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.rfcTextBox = new System.Windows.Forms.TextBox();
            this.horario_aperturaTextBox = new System.Windows.Forms.TextBox();
            this.horario_cierreTextBox = new System.Windows.Forms.TextBox();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            rfcLabel = new System.Windows.Forms.Label();
            horario_aperturaLabel = new System.Windows.Forms.Label();
            horario_cierreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tallermecanicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingNavigator)).BeginInit();
            this.proveedorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(30, 49);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(104, 27);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(30, 89);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(109, 27);
            telefonoLabel.TabIndex = 3;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(30, 129);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(91, 27);
            correoLabel.TabIndex = 5;
            correoLabel.Text = "Correo:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(30, 169);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(118, 27);
            direccionLabel.TabIndex = 7;
            direccionLabel.Text = "Direccion:";
            // 
            // rfcLabel
            // 
            rfcLabel.AutoSize = true;
            rfcLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rfcLabel.Location = new System.Drawing.Point(30, 209);
            rfcLabel.Name = "rfcLabel";
            rfcLabel.Size = new System.Drawing.Size(68, 27);
            rfcLabel.TabIndex = 9;
            rfcLabel.Text = "RFC:";
            // 
            // horario_aperturaLabel
            // 
            horario_aperturaLabel.AutoSize = true;
            horario_aperturaLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horario_aperturaLabel.Location = new System.Drawing.Point(30, 249);
            horario_aperturaLabel.Name = "horario_aperturaLabel";
            horario_aperturaLabel.Size = new System.Drawing.Size(227, 27);
            horario_aperturaLabel.TabIndex = 11;
            horario_aperturaLabel.Text = "Horario de apertura:";
            // 
            // horario_cierreLabel
            // 
            horario_cierreLabel.AutoSize = true;
            horario_cierreLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horario_cierreLabel.Location = new System.Drawing.Point(30, 289);
            horario_cierreLabel.Name = "horario_cierreLabel";
            horario_cierreLabel.Size = new System.Drawing.Size(196, 27);
            horario_cierreLabel.TabIndex = 13;
            horario_cierreLabel.Text = "Horario de cierre:";
            // 
            // tallermecanicoDataSet
            // 
            this.tallermecanicoDataSet.DataSetName = "tallermecanicoDataSet";
            this.tallermecanicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.tallermecanicoDataSet;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.proveedor_insumoTableAdapter = null;
            this.tableAdapterManager.proveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.servicioTableAdapter = null;
            this.tableAdapterManager.tipo_insumoTableAdapter = null;
            this.tableAdapterManager.tipo_servicioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Taller_Mecanico.tallermecanicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // proveedorBindingNavigator
            // 
            this.proveedorBindingNavigator.AddNewItem = null;
            this.proveedorBindingNavigator.BindingSource = this.proveedorBindingSource;
            this.proveedorBindingNavigator.CountItem = null;
            this.proveedorBindingNavigator.DeleteItem = null;
            this.proveedorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.proveedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorBindingNavigatorSaveItem});
            this.proveedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proveedorBindingNavigator.MoveFirstItem = null;
            this.proveedorBindingNavigator.MoveLastItem = null;
            this.proveedorBindingNavigator.MoveNextItem = null;
            this.proveedorBindingNavigator.MovePreviousItem = null;
            this.proveedorBindingNavigator.Name = "proveedorBindingNavigator";
            this.proveedorBindingNavigator.PositionItem = null;
            this.proveedorBindingNavigator.Size = new System.Drawing.Size(553, 27);
            this.proveedorBindingNavigator.TabIndex = 0;
            this.proveedorBindingNavigator.Text = "bindingNavigator1";
            // 
            // proveedorBindingNavigatorSaveItem
            // 
            this.proveedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proveedorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedorBindingNavigatorSaveItem.Image")));
            this.proveedorBindingNavigatorSaveItem.Name = "proveedorBindingNavigatorSaveItem";
            this.proveedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.proveedorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.proveedorBindingNavigatorSaveItem.Click += new System.EventHandler(this.proveedorBindingNavigatorSaveItem_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(265, 46);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(239, 34);
            this.nombreTextBox.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(265, 86);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(239, 34);
            this.telefonoTextBox.TabIndex = 4;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "correo", true));
            this.correoTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(265, 126);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(239, 34);
            this.correoTextBox.TabIndex = 6;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(265, 166);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(239, 34);
            this.direccionTextBox.TabIndex = 8;
            // 
            // rfcTextBox
            // 
            this.rfcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "rfc", true));
            this.rfcTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfcTextBox.Location = new System.Drawing.Point(265, 206);
            this.rfcTextBox.Name = "rfcTextBox";
            this.rfcTextBox.Size = new System.Drawing.Size(239, 34);
            this.rfcTextBox.TabIndex = 10;
            // 
            // horario_aperturaTextBox
            // 
            this.horario_aperturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "horario_apertura", true));
            this.horario_aperturaTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario_aperturaTextBox.Location = new System.Drawing.Point(265, 246);
            this.horario_aperturaTextBox.Name = "horario_aperturaTextBox";
            this.horario_aperturaTextBox.Size = new System.Drawing.Size(239, 34);
            this.horario_aperturaTextBox.TabIndex = 12;
            // 
            // horario_cierreTextBox
            // 
            this.horario_cierreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "horario_cierre", true));
            this.horario_cierreTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario_cierreTextBox.Location = new System.Drawing.Point(265, 286);
            this.horario_cierreTextBox.Name = "horario_cierreTextBox";
            this.horario_cierreTextBox.Size = new System.Drawing.Size(239, 34);
            this.horario_cierreTextBox.TabIndex = 14;
            // 
            // crearpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 365);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(rfcLabel);
            this.Controls.Add(this.rfcTextBox);
            this.Controls.Add(horario_aperturaLabel);
            this.Controls.Add(this.horario_aperturaTextBox);
            this.Controls.Add(horario_cierreLabel);
            this.Controls.Add(this.horario_cierreTextBox);
            this.Controls.Add(this.proveedorBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "crearpedido";
            this.Text = "crearpedido";
            this.Load += new System.EventHandler(this.crearpedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tallermecanicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingNavigator)).EndInit();
            this.proveedorBindingNavigator.ResumeLayout(false);
            this.proveedorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tallermecanicoDataSet tallermecanicoDataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private tallermecanicoDataSetTableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private tallermecanicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proveedorBindingNavigator;
        private System.Windows.Forms.ToolStripButton proveedorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox rfcTextBox;
        private System.Windows.Forms.TextBox horario_aperturaTextBox;
        private System.Windows.Forms.TextBox horario_cierreTextBox;
    }
}