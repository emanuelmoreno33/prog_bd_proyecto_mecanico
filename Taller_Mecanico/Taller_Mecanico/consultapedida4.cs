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
    public partial class consultapedida4 : Form
    {
        string conexion = "server=db4free.net;user id=saedemci;password=Peamspne4;persistsecurityinfo=True;oldguids=True;database=tallermecanicop;allowuservariables=True";
        int valor = 0;
        public consultapedida4()
        {
            InitializeComponent();
        }

        private void consultapedida4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.tallermecanicoDataSet.departamento);

        }

        private DataTable Cargardatos4()
        {
            string Query = "SELECT count(reparacion)as veces,reparacion FROM tallermecanicop.consulta4_reparaciones_departamento where departamento = '"+comboBox1.SelectedValue+"' group by reparacion order by veces desc;";
            DataTable dt = new DataTable();
            MySqlConnection MyConn2 = new MySqlConnection(conexion);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MyConn2.Close();
            return dt;
        }

        private DataTable Cargardatos6()
        {
            string Query = "SELECT * FROM tallermecanicop.consulta6_consumo_refacciones_departamento where departamento ='" + comboBox1.SelectedValue + "' ;";
            DataTable dt = new DataTable();
            MySqlConnection MyConn2 = new MySqlConnection(conexion);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MyConn2.Close();
            return dt;
        }

        public void ShowDialog(ref int consulta)
        {
            valor = consulta;
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valor == 4)
                dataGridView1.DataSource = Cargardatos4();
            else if (valor == 6)
            {
                dataGridView1.DataSource = Cargardatos6();
            }

        }
    }
}
