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
    public partial class AgregadorIncidencias : Form
    {
        String[] tipoIncidencia = {
            "Elegir el Tipo incidencia...",
            "Software",
            "Hardware",
            };
        String[] estadoIncidencia = {
            "Elegir Estado de la incidencia...",
            "Emitida",
            "En proceso",
            "Cerrada"
            };
        public AgregadorIncidencias()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void rellenar(ComboBox cb, String selected, String[] array)
        {
            cb.Items.Clear();
            foreach (String s in array)
            {
                cb.Items.Add(s);
            }
            if (selected == null)
                cb.SelectedIndex = 0;
            else
                cb.SelectedItem = selected;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            rellenar(cbTipo, null,tipoIncidencia);
            rellenar(cbEstadoIncidencia, null,estadoIncidencia);
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
