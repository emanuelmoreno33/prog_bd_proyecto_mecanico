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
    public partial class agregarcliente : Form
    {
        public agregarcliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void agregarcliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.tallermecanicoDataSet.cliente);

        }
    }
}
