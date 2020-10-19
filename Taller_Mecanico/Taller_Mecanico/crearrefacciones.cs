using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Mecanico
{
    public partial class crearrefacciones : Form
    {
        public crearrefacciones()
        {
            InitializeComponent();
        }

        private void compra_insumoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compra_insumoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void crearrefacciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.compra_insumo' Puede moverla o quitarla según sea necesario.
            this.compra_insumoTableAdapter.Fill(this.tallermecanicoDataSet.compra_insumo);

        }
    }
}
