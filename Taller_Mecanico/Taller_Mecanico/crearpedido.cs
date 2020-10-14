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
    public partial class crearpedido : Form
    {
        public crearpedido()
        {
            InitializeComponent();
        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void crearpedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.pedido' Puede moverla o quitarla según sea necesario.
            this.pedidoTableAdapter.Fill(this.tallermecanicoDataSet.pedido);

        }
    }
}
