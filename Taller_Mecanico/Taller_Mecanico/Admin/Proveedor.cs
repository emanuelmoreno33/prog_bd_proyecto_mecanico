using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Mecanico.Admin
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();

            this.tallermecanicoDataSet.proveedor.TableNewRow += Proveedor_TableNewRow;
            this.proveedorDataGridView.CellValueChanged += ProveedorDataGridView_CellValueChanged;
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallermecanicoDataSet.proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.tallermecanicoDataSet.proveedor);
        }

        private void Proveedor_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row.BeginEdit();
            e.Row.SetField("creado_por", 1);
            e.Row.SetField("fecha_creado", DateTime.Now);
            e.Row.EndEdit();
        }

        private void ProveedorDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            proveedorDataGridView.Rows[e.RowIndex].Cells[10].Value = 1;
            proveedorDataGridView.Rows[e.RowIndex].Cells[11].Value = DateTime.Now;
        }
    }
}
