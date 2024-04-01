using SistemasVentas.BSS;
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
    public partial class Pregunta8 : Form
    {
        public Pregunta8()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void Pregunta8_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ExamenProveedoresBass();
        }
    }
}
