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
            crearpedido pedido = new crearpedido();
            pedido.ShowDialog(ref idusuario);
        }
        //editar pedidos
        private void editarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //crear proveedores
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearprooveedor crear = new crearprooveedor();
            crear.ShowDialog();
        }
        //ventana principal
        private void Principal_Load(object sender, EventArgs e)
        {
            if(admin==0)
            {
                verClientesToolStripMenuItem.Visible = false;
                insumosToolStripMenuItem.Visible = false;
                administracionToolStripMenuItem.Visible = false;
            }
            else
            {
                verClientesToolStripMenuItem.Visible = true;
                insumosToolStripMenuItem.Visible = true;
                administracionToolStripMenuItem.Visible = true;
            }
        }
        
        //agregar departamento
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string departamento = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo departamento","Agregar proveedor");

        }
        //agregar marca de auto
        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string marca = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la marca de auto", "Agregar Marca de auto");
        }
        //estado
        private void agregarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            string estado = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo estado", "Agregar estado");
        }
        //crear usuarios
        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            crearusuarios usuario = new crearusuarios();
            usuario.ShowDialog();
        }
        //crear clientes
        private void agregaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //crear insumos
        private void agregarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //ver pedidos
        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //editar clientes
        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //editar insumos
        private void editarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //editar prooveedores
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //editar departamentos
        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        //editar usuarios
        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        //editar marcas de auto
        private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
        //editar servicio
        private void editarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }
        //editar estado
        private void editarToolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }
        //consulta 10
        private void trabajadorConMasGarantiasAplicadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaspedida10 consulta = new consultaspedida10();
            int valor = 10;
            consulta.ShowDialog(ref valor);
        }
        //consulta 1
        private void clienteConMayorFrecuenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultapedida1 consulta = new consultapedida1();
            int valor = 1;
            consulta.ShowDialog(ref valor);
        }
        //consulta 2
        private void ventasObtenidasDeDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaspedida10 consulta = new consultaspedida10();
            int valor = 2;
            consulta.ShowDialog(ref valor);
        }
        //consulta 3
        private void empleadoConMayorVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultapedida1 consulta = new consultapedida1();
            int valor = 3;
            consulta.ShowDialog(ref valor);
        }
        //consulta 4
        private void reparacionesMasConcurrentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultapedida4 consulta = new consultapedida4();
            int valor = 4;
            consulta.ShowDialog(ref valor);
        }
        //consulta 5
        private void departamentoConMasAfluenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultapedida1 consulta = new consultapedida1();
            int valor = 5;
            consulta.ShowDialog(ref valor);
        }
        //consulta 6
        private void consumoDeRefaccionesPorDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultapedida4 consulta = new consultapedida4();
            int valor = 6;
            consulta.ShowDialog(ref valor);
        }
        //consulta 7
        private void caracteristicasDeLosAutomovilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultapedida1 consulta = new consultapedida1();
            int valor = 7;
            consulta.ShowDialog(ref valor);
        }
        //consulta 8
        private void clienteConMayorGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaspedida10 consulta = new consultaspedida10();
            int valor = 8;
            consulta.ShowDialog(ref valor);
        }
        //consulta 9
        private void refaccionMasVendidaYSuGananciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaspedida10 consulta = new consultaspedida10();
            int valor = 9;
            consulta.ShowDialog(ref valor);
        }
    }
}
