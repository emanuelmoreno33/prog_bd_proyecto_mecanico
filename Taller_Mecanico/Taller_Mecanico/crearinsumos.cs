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
    public partial class crearinsumos : Form
    {
        public crearinsumos()
        {
            InitializeComponent();
        }

        private void insumoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.insumoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void crearinsumos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.insumo' Puede moverla o quitarla según sea necesario.
            this.insumoTableAdapter.Fill(this.tallermecanicoDataSet.insumo);

        }
    }
}
