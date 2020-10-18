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
    public partial class TipoDeServicio : Form
    {
        public TipoDeServicio()
        {
            InitializeComponent();
            this.tallermecanicoDataSet.tipo_servicio.TableNewRow += Tipo_servicio_TableNewRow; ;
            this.tipo_servicioDataGridView.CellValueChanged += Tipo_servicioDataGridView_CellValueChanged;
        }

        private void tipo_servicioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipo_servicioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void TipoDeServicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallermecanicoDataSet.tipo_servicio' table. You can move, or remove it, as needed.
            this.tipo_servicioTableAdapter.Fill(this.tallermecanicoDataSet.tipo_servicio);

        }

        private void Tipo_servicio_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row.BeginEdit();
            e.Row.SetField("creado_por", 1);
            e.Row.SetField("fecha_creado", DateTime.Now);
            e.Row.EndEdit();
        }

        private void Tipo_servicioDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tipo_servicioDataGridView.Rows[e.RowIndex].Cells[4].Value = 1;
            tipo_servicioDataGridView.Rows[e.RowIndex].Cells[5].Value = DateTime.Now;
        }
    }
}
