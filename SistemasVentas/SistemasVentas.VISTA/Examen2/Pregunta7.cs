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
    public partial class Pregunta7 : Form
    {
        public Pregunta7()
        {
            InitializeComponent();
        }
        ClienteBss bss =new ClienteBss();
        private void Pregunta7_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ExamenClientesBass();
        }
    }
}
