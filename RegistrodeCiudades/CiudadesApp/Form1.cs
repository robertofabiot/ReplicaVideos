﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiudadesLibrary;
using CiudadesLibrary.Dao;

namespace CiudadesApp
{
    public partial class Form1 : Form
    {
        CiudadDao lista = new CiudadDao();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.Nombre = tbNombre.Text;
            ciudad.Poblacion = int.Parse(tbPoblacion.Text);
            ciudad.FechaFundacion = dtpFundacion.Value;


            lista.AgregarCiudad(ciudad);
            llenarDataGrid();
        }

        private void llenarDataGrid()
        {
            dgvRegistros.DataSource = lista.MostrarCiudad();
            dgvRegistros.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
