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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
            this.tallermecanicoDataSet.usuario.TableNewRow += Usuario_TableNewRow;
            this.usuarioDataGridView.CellValueChanged += UsuarioDataGridView_CellValueChanged;
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tallermecanicoDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.tallermecanicoDataSet.usuario);

        }

        private void UsuarioDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            usuarioDataGridView.Rows[e.RowIndex].Cells[7].Value = 1;
            usuarioDataGridView.Rows[e.RowIndex].Cells[8].Value = DateTime.Now;
        }

        private void Usuario_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            e.Row.BeginEdit();
            e.Row.SetField("creado_por", 1);
            e.Row.SetField("fecha_creado", DateTime.Now);
            e.Row.EndEdit();
        }
    }
}
