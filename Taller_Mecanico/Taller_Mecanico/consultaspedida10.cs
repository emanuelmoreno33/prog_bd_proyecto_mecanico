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
    public partial class consultaspedida10 : Form
    {
        string conexion = "server=db4free.net;user id=saedemci;password=Peamspne4;persistsecurityinfo=True;oldguids=True;database=tallermecanicop;allowuservariables=True";
        int valor = 1;
        public consultaspedida10()
        {
            InitializeComponent();
        }

        private DataTable Cargardatos2()
        {
            string Query = "select * from consulta2_ventas_tipo_servicio";
            DataTable dt = new DataTable();
            MySqlConnection MyConn2 = new MySqlConnection(conexion);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MyConn2.Close();
            return dt;
        }

        private DataTable Cargardatos8()
        {
            string Query = "SELECT nombre,apellido,correo,RFC,telefono,count(id) as veces,sum(total) as gastos FROM tallermecanicop.consulta8_cliente_gastos group by id order by gastos desc limit 1;";
            DataTable dt = new DataTable();
            MySqlConnection MyConn2 = new MySqlConnection(conexion);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MyConn2.Close();
            return dt;
        }

        private DataTable Cargardatos9()
        {
            string Query = "SELECT departamento,insumo,tipo_insumo,nombre,(precio_venta*cantidad)-((importe+impuesto-descuento)*cantidad) as ganancia FROM tallermecanicop.consulta9_refaccion_departamento where departamento = 'Refaccionaria' order by ganancia desc limit 1;";
            DataTable dt = new DataTable();
            MySqlConnection MyConn2 = new MySqlConnection(conexion);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MyConn2.Close();
            return dt;
        }

        private DataTable Cargardatos10()
        {
            string Query = "select * from consulta10_trabajor_garantias";
            DataTable dt = new DataTable();
            MySqlConnection MyConn2 = new MySqlConnection(conexion);
            var cmd = new MySqlCommand(Query, MyConn2);
            MyConn2.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            MyConn2.Close();
            return dt;
        }

        private void consultaspedidas_Load(object sender, EventArgs e)
        {
            if (valor == 2)
                dataGridView1.DataSource = Cargardatos2();
            else if (valor == 8)
                dataGridView1.DataSource = Cargardatos8();
            else if (valor == 9)
                dataGridView1.DataSource = Cargardatos9();
            else if (valor == 10)
                dataGridView1.DataSource = Cargardatos10();

        }

        public void ShowDialog(ref int consulta)
        {
            valor = consulta;
            this.ShowDialog();
        }
    }
}
