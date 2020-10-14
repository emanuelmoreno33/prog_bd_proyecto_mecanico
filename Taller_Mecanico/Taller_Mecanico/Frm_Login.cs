using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Taller_Mecanico
{
    public partial class Frm_Login : Form
    {
        string conexion = "server=db4free.net;user id=saedemci;password=Peamspne4;persistsecurityinfo=True;oldguids=True;database=tallermecanicop;allowuservariables=True";
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            string usuario = txtusu.Text;
            string contrasena = txtpass.Text;
            int[] comprobacion = comprobarusuarios(usuario, contrasena);

            if(comprobacion[0]==0)
            {
                MessageBox.Show("Usuario no registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Principal forma = new Principal();
                txtusu.ResetText();
                txtpass.ResetText();
                int idiniciado = comprobacion[1];
                int administrado = comprobacion[2];
                forma.ShowDialog(ref idiniciado, usuario,administrado);
            }

        }

        private int[] comprobarusuarios(string usuario, string contrasena)
        {
            int[] registros = new int[3];
            try
            {
                string Query = "SELECT COUNT(*),id_usuario,supervisor FROM usuario where usuario = '" + usuario + "' and contrasena = md5('" + contrasena + "');";
                MySqlConnection MyConn2 = new MySqlConnection(conexion);
                var cmd = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    registros[0] = rdr.GetInt32(0);
                    registros[1] = rdr.GetInt32(1);
                    registros[2] = rdr.GetInt32(2);

                }
                MyConn2.Close();
            }
            catch
            {
                registros[0] = 0;
                registros[1] = 0;
                registros[2] = 0;
            }
            return registros;
        }
    }
}
