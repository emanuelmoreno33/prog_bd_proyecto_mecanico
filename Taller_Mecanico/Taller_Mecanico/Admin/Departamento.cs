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
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
            this.tallermecanicoDataSet.departamento.TableNewRow += Departamento_TableNewRow;
            this.departamentoDataGridView.CellValueChanged += DepartamentoDataGridView_CellValueChanged;
        }

        private void departamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void Departamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallermecanicoDataSet.departamento' table. You can move, or remove it, as needed.
            this.departamentoTableAdapter.Fill(this.tallermecanicoDataSet.departamento);

        }

        private void DepartamentoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            departamentoDataGridView.Rows[e.RowIndex].Cells[4].Value = 1;
            departamentoDataGridView.Rows[e.RowIndex].Cells[5].Value = DateTime.Now;
        }

        private void Departamento_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row.BeginEdit();
            e.Row.SetField("creado_por", 1);
            e.Row.SetField("fecha_creado", DateTime.Now);
            e.Row.EndEdit();
        }
    }
}
