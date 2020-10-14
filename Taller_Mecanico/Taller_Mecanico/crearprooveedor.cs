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
    public partial class crearprooveedor : Form
    {
        string conexion = "server=db4free.net;user id=saedemci;password=Peamspne4;persistsecurityinfo=True;oldguids=True;database=tallermecanicop;allowuservariables=True";
        public crearprooveedor()
        {
            InitializeComponent();
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string query = "Insert into ";
        }

        private void crearpedido_Load(object sender, EventArgs e)
        {

        }
    }
}
