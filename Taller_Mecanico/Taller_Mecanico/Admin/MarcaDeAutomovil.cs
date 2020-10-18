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
    public partial class MarcaDeAutomovil : Form
    {
        public MarcaDeAutomovil()
        {
            InitializeComponent();
            this.tallermecanicoDataSet.marca.TableNewRow += Marca_TableNewRow;
            this.marcaDataGridView.CellValueChanged += MarcaDataGridView_CellValueChanged;
        }

        private void marcaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void MarcaDeAutomovil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallermecanicoDataSet.marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.tallermecanicoDataSet.marca);

        }

        private void MarcaDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            marcaDataGridView.Rows[e.RowIndex].Cells[4].Value = 1;
            marcaDataGridView.Rows[e.RowIndex].Cells[5].Value = DateTime.Now;
        }

        private void Marca_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row.BeginEdit();
            e.Row.SetField("creado_por", 1);
            e.Row.SetField("fecha_creado", DateTime.Now);
            e.Row.EndEdit();
        }
    }
}
