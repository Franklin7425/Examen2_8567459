﻿using SistemasVentas.BSS;
using SistemasVentas.Modelos;
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
    public partial class Pregunta6 : Form
    {
        public Pregunta6()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void Pregunta6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuariosBass();
        }
    }
}
