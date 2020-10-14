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
    public partial class Principal : Form
    {
        int idusuario = 0;
        int admin = 0;
        public Principal()
        {
            InitializeComponent();
        }
        public void ShowDialog(ref int idiniciado, string nombre,int administrador)
        {
            idusuario = idiniciado;
            admin = administrador;
            letrerousuario.Text = "Usuario: " + nombre;
            this.ShowDialog();
        }

        private void crearPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearprooveedor crear = new crearprooveedor();
            crear.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string departamento = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo departamento","Agregar proveedor");

        }
    }
}
