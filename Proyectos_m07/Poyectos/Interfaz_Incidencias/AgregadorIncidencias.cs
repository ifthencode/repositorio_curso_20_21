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
        
        ListView lista;
        public AgregadorIncidencias(ListView lv)
        {
            InitializeComponent();
            lista = lv;
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

        private void button1_Click(object sender, EventArgs e)
        {
            String comprobar = comprobarVacio();
            if (comprobar.Equals("NOOK"))
            {
                MessageBox.Show("Los campos ,tipo,asunto, email y estado son obligatorios ");

            }
            else
            {
                ListViewItem item = new ListViewItem();
                String fechaApertura = dtApertura.Value.ToString();
               // String fechaCierre = dtCierre.Value.ToString();
                item.SubItems.Add(cbTipo.Text);
                item.SubItems.Add(tbAsunto.Text);
                item.SubItems.Add(tBEmailPantallaAgreqar.Text);
                item.SubItems.Add(cbEstadoIncidencia.Text);
                item.SubItems.Add(fechaApertura);
                item.SubItems.Add("");
                lista.Items.Insert(0, item);
                lista.GridLines = true;
                this.Close();
                
            }
           
        }

        private string comprobarVacio() {
            if (cbTipo.SelectedIndex == 0 | tbAsunto.Text.Equals("") | tBEmailPantallaAgreqar.Text.Equals("")| cbEstadoIncidencia.SelectedIndex == 0)
            {
                return "NOOK";

            }
            else { return "OK"; };

            
        }

        private void textBoxAsunto_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
