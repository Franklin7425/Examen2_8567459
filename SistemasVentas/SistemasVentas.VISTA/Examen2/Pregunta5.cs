﻿using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.Examen2
{
    public partial class Pregunta5 : Form
    {
        public Pregunta5()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void Pregunta5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetallesIngBass();
        }
    }
}