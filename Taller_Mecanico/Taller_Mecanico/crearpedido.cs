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
    public partial class crearpedido : Form
    {
        string conexion = "server=db4free.net;user id=saedemci;password=Peamspne4;persistsecurityinfo=True;oldguids=True;database=tallermecanicop;allowuservariables=True";
        int idusuario = 0;
        public crearpedido()
        {
            InitializeComponent();
        }

        public void ShowDialog(ref int usuario)
        {
            idusuario = usuario;
            this.ShowDialog();
        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into pedido(placa,modelo,id_marca,id_usuario,id_cliente,fecha_registro,fecha_entrega,id_estado,subtotal,impuesto,descuento,total) values('" + placaTextBox.Text + "','" + modeloTextBox.Text + "'," + id_marcaComboBox.SelectedValue + "," + idusuario + "," + id_clienteComboBox.SelectedValue + ",'" + fecha_registroDateTimePicker.Value.Date.ToString("yyyy-MM-dd") + "','" + fecha_entregaDateTimePicker.Value.Date.ToString("yyyy-MM-dd") + "',"+id_estadoComboBox.SelectedValue+","+subtotalTextBox.Text+","+impuestoTextBox.Text+","+descuentoTextBox.Text+","+totalTextBox.Text+");";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(conexion);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Datos guardados", "Aviso", MessageBoxButtons.OK);
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void crearpedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.estado' Puede moverla o quitarla según sea necesario.
            this.estadoTableAdapter.Fill(this.tallermecanicoDataSet.estado);
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.tallermecanicoDataSet.cliente);
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.tallermecanicoDataSet.marca);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal subtotal, impuesto, descuento,total;
            subtotal = decimal.Parse(subtotalTextBox.Text);
            impuesto = decimal.Parse(impuestoTextBox.Text);
            descuento = decimal.Parse(descuentoTextBox.Text);

            total = (subtotal * (impuesto+1)) - descuento;
            totalTextBox.Text = total.ToString();

        }
    }
}
