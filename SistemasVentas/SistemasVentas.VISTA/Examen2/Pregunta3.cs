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
    public partial class Pregunta3 : Form
    {
        public Pregunta3()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void Pregunta3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= bss.ListarMarcasBass();
        }
    }
}
