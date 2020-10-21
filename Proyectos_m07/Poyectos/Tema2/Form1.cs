using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2
{
    public partial class Form1 : Form
    {
       
        String[] equipos = {
            "Elegir Equipo...",
            "Real Madrid",
            "F.C. Barcelona",
            "RCE Espanyol",
            "Atletico Madrid"};
        bool formOk = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void rellenar(ComboBox cb, String selected)
        {
            cb.Items.Clear();
            foreach (String s in equipos)
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
            rellenar(cbLocal,null);
            rellenar(cbVisitante,null);
            enableTools(false);
            formOk = true;
        }

        private void seleccion(object sender, EventArgs e)
        {
            if (!formOk) return;
            ComboBox activo = (ComboBox)sender;
            ComboBox inactivo;
            if (activo.Name == "cbLocal") inactivo = cbVisitante;
            else inactivo = cbLocal;
            formOk = false;
            rellenar(inactivo, inactivo.SelectedItem.ToString());
            if (activo.SelectedIndex != 0)
                inactivo.Items.Remove(activo.SelectedItem);
            formOk = true;
        }

        private void enableTools(bool value)
        {
            toolLocal.Enabled = value;
            toolVisitante.Enabled = value;
            toolGol.Enabled = value;
            toolAmarilla.Enabled = value;
            toolRoja.Enabled = value;
            toolTiempo.Enabled = value;
            toolInicio.Enabled = !value;
            menuInicio.Enabled = !value;
            menuMarcador.Enabled = value;
            menuEventos.Enabled = value;
        }

        private void resetMatch(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos se perderán. ¿Continuar?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cbLocal.Enabled = true;
                cbVisitante.Enabled = true;
                enableTools(false);
                lvEventos.Items.Clear();
                nudLocal.Value = 0;
                nudVisitante.Value = 0;
                formOk = false;
                rellenar(cbLocal, null);
                rellenar(cbVisitante, null);
                formOk = true;
            }
        }

        private void startMatch(object sender, EventArgs e)
        {
            if (cbLocal.SelectedIndex==0 || cbVisitante.SelectedIndex == 0)
            {
                MessageBox.Show("Selecciona ambos equipos antes de iniciar el partido", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            cbLocal.Enabled = false;
            cbVisitante.Enabled = false;
            enableTools(true);
            nudLocal.Value = 0;
            nudVisitante.Value = 0;
            ListViewItem item = new ListViewItem();
            item.ImageIndex = 3;
            item.SubItems.Add("0");
            item.SubItems.Add("Arranca el partido!");
            lvEventos.Items.Add(item);

        }

        private void golL(object sender, EventArgs e)
        {
            nudLocal.Value++;
        }
        private void golV(object sender, EventArgs e)
        {
            nudVisitante.Value++;
        }
        private void clearEvents(object sender, EventArgs e)
        {
            lvEventos.Items.Clear();
        }

        private void newEvent(object sender, EventArgs e)
        {
            nuevoEvento ne = new nuevoEvento(iconosGrandes,lvEventos,0);
            ne.ShowDialog();
        }

        private void toolGol_Click(object sender, EventArgs e)
        {
            nuevoEvento ne = new nuevoEvento(iconosGrandes, lvEventos, 0);
            ne.ShowDialog();
        }

        private void toolAmarilla_Click(object sender, EventArgs e)
        {
            nuevoEvento ne = new nuevoEvento(iconosGrandes, lvEventos, 1);
            ne.ShowDialog();
        }

        private void toolRoja_Click(object sender, EventArgs e)
        {
            nuevoEvento ne = new nuevoEvento(iconosGrandes, lvEventos, 2);
            ne.ShowDialog();
        }

        private void toolTiempo_Click(object sender, EventArgs e)
        {
            nuevoEvento ne = new nuevoEvento(iconosGrandes, lvEventos, 3);
            ne.ShowDialog();
        }
    }
}
