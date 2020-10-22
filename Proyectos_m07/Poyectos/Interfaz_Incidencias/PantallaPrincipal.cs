﻿using System;
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
            AgregadorIncidencias ai = new AgregadorIncidencias(lvIncidencias);


            ai.Show();
        }

        private void nuevaIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregadorIncidencias ai = new AgregadorIncidencias(lvIncidencias);


            ai.Show();
        }

        private void lvIncidencias_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarIncidencia mi;
            String estado;
           
            try
            {
                 
                if (lvIncidencias.SelectedItems[0].Selected)
                {
                    estado = lvIncidencias.SelectedItems[0].SubItems[4].Text;
                
                    mi = new ModificarIncidencia(lvIncidencias, estado);
                    mi.Show();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una incidencia ");

                }
            }
            catch (Exception ex)
            {
                
            }

           
           


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem itemr = lvIncidencias.SelectedItems[0];
            int posicion=0;
            int numero = 0;
            foreach (ListViewItem iteml in lvIncidencias.Items)
            {


                if (iteml == itemr)
                {

                    posicion = numero;

                };
                numero++;
            }
            lvIncidencias.Items.RemoveAt(posicion);
        }
    }
}
