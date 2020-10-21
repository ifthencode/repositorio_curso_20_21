using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Incidencias
{
    public partial class Incidencias : Form
    {
        public Incidencias()
        {
            InitializeComponent();
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {

        }

      
        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nuevaIncidencia_Click(object sender, EventArgs e)
        {
            AgregadorIncidencias ai = new AgregadorIncidencias();


            ai.Show();
        }

        private void nuevaIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregadorIncidencias ai = new AgregadorIncidencias();


            ai.Show();
        }
    }
}
