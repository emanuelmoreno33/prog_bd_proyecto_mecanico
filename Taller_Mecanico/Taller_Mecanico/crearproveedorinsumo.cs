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
    public partial class crearproveedorinsumo : Form
    {
        public crearproveedorinsumo()
        {
            InitializeComponent();
        }

        private void proveedor_insumoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedor_insumoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void crearproveedorinsumo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.proveedor_insumo' Puede moverla o quitarla según sea necesario.
            this.proveedor_insumoTableAdapter.Fill(this.tallermecanicoDataSet.proveedor_insumo);

        }
    }
}
