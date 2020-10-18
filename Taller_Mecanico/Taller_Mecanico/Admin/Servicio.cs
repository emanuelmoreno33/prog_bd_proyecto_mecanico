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
    public partial class Servicio : Form
    {
        public Servicio()
        {
            InitializeComponent();
            this.tallermecanicoDataSet.servicio.TableNewRow += Servicio_TableNewRow;
            this.servicioDataGridView.CellValueChanged += ServicioDataGridView_CellValueChanged;
        }

        private void servicioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void Servicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallermecanicoDataSet.servicio' table. You can move, or remove it, as needed.
            this.servicioTableAdapter.Fill(this.tallermecanicoDataSet.servicio);

        }

        private void ServicioDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            servicioDataGridView.Rows[e.RowIndex].Cells[8].Value = 1;
            servicioDataGridView.Rows[e.RowIndex].Cells[9].Value = DateTime.Now;
        }

        private void Servicio_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row.BeginEdit();
            e.Row.SetField("creado_por", 1);
            e.Row.SetField("fecha_creado", DateTime.Now);
            e.Row.EndEdit();
        }
    }
}
