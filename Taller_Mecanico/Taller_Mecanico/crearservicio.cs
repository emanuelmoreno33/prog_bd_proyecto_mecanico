﻿using System;
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
    public partial class crearservicio : Form
    {
        public crearservicio()
        {
            InitializeComponent();
        }

        private void servicioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tallermecanicoDataSet);

        }

        private void crearservicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tallermecanicoDataSet.servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.tallermecanicoDataSet.servicio);

        }
    }
}
