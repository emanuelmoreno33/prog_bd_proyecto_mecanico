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

    public partial class consultapedida1 : Form
    {
        string conexion = "server=db4free.net;user id=saedemci;password=Peamspne4;persistsecurityinfo=True;oldguids=True;database=tallermecanicop;allowuservariables=True";
        int valor = 1;
        public consultapedida1()
        {
            InitializeComponent();
        }

        private void consultapedida1_Load(object sender, EventArgs e)
        {
           
        }
        private DataTable Cargardatos1()
        {
            string Query = "SELECT nombre,apellido,correo,telefono,RFC, count(nombre) as veces FROM tallermecanicop.consulta_cliente_servicio where fecha_registro >='"+dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")+ "' and fecha_registro <='"+dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "' group by id_cliente order by veces desc limit 1;";
            DataTable dt = new DataTable();
            MySqlConnection MyConn2 = new MySqlConnection(conexion);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            MyConn2.Close();
            return dt;
        }

        private DataTable Cargardatos3()
        {
            string Query = "SELECT usuario, count(id_usuario) as veces FROM tallermecanicop.consulta3_usuario_ventas_pedidos where fecha_registro >= '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' and fecha_registro <='" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "' group by id_usuario;";
            DataTable dt = new DataTable();
            MySqlConnection MyConn2 = new MySqlConnection(conexion);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MyConn2.Close();
            return dt;
        }

        private DataTable Cargardatos5()
        {
            string Query = "SELECT descripcion, count(descripcion) as veces FROM tallermecanicop.consulta5_departamento_servicio where fecha_creado >= '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' and fecha_creado <='" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "' group by descripcion order by veces desc;";
            DataTable dt = new DataTable();
            MySqlConnection MyConn2 = new MySqlConnection(conexion);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MyConn2.Close();
            return dt;
        }

        private DataTable Cargardatos7()
        {
            string Query = "SELECT * FROM tallermecanicop.consulta7_descripcion_vehiculos  where fecha_registro >= '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' and fecha_registro <='" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "';";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (valor == 1)
            dataGridView1.DataSource = Cargardatos1();
            else if(valor == 3)
            {
                dataGridView1.DataSource = Cargardatos3();
            }
            else if (valor == 5)
            {
                dataGridView1.DataSource = Cargardatos5();
            }
            else if(valor == 7)
            {
                dataGridView1.DataSource = Cargardatos7();
            }

        }
    }
}
