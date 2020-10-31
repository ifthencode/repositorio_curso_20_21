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
    public partial class ModificarIncidencia : Form
    {
        String[] estadoIncidencia = {
            "Elegir Estado de la incidencia...",
            "Emitida",
            "En proceso",
            "Cerrada"
            };
        ListView lista;
        String estado = null;
        String email=null;
        public ModificarIncidencia(ListView lv,String estado)
        {
            this.estado = estado;
            lista = lv;
            InitializeComponent();

           

        }
        public ModificarIncidencia()
        {
            
            InitializeComponent();



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
        private void Form1_Shown(object sender, EventArgs e)
        {
            email = lista.SelectedItems[0].SubItems[3].Text;
            rellenar(cbEstadoIncidencia, estado, estadoIncidencia);
            tbEmailPantallaModificar.Text = email;
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
                String fechaCierre = dtCierre.Value.ToString();
                ListViewItem item = new ListViewItem();
                ListViewItem itemr = lista.SelectedItems[0];
                int posicion = lista.SelectedIndices.Count;
                int numero = 0;
                foreach (ListViewItem iteml in lista.Items)
                {


                    if (iteml == itemr)
                    {

                        posicion = numero;

                    };
                    numero++;
                }

                item.SubItems.Add(lista.SelectedItems[0].SubItems[1].Text);
                item.SubItems.Add(lista.SelectedItems[0].SubItems[2].Text);
                item.SubItems.Add(tbEmailPantallaModificar.Text);
                item.SubItems.Add(cbEstadoIncidencia.Text);
                item.SubItems.Add(lista.SelectedItems[0].SubItems[5].Text);
                item.SubItems.Add(fechaCierre);
                lista.Items.Remove(itemr);
                lista.Items.Insert(posicion, item);
                this.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbEstadoIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  rellenar(cbEstadoIncidencia, null, estadoIncidencia);

        }

        private void ModificarIncidencia_Load(object sender, EventArgs e)
        {
          // rellenar(cbEstadoIncidencia, lista.SelectedItems[0].SubItems[4].Text, estadoIncidencia);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string comprobarVacio()
        {
            if (cbEstadoIncidencia.SelectedIndex == 0)
            {
                return "NOOK";

            }
            else { return "OK"; };


        }
    }
}
