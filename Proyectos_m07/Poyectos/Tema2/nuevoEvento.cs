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
    public partial class nuevoEvento : Form
    {
        ImageList imgs;
        ListView lista;
        int icono;
        public nuevoEvento(ImageList il,ListView lv,int ico)
        {
            InitializeComponent();
            imgs = il;
            lista = lv;
            icono = ico;
            
        }

        private void nuevoEvento_Shown(object sender, EventArgs e)
        {
            pbIcono.Image = imgs.Images[icono];
            pbfondo.BackColor = Color.White;
        }
        private void btSiguiente_Click(object sender, EventArgs e)
        {
            icono = (icono + 1) % imgs.Images.Count;
            pbIcono.Image = imgs.Images[icono];
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            icono = (icono - 1+ imgs.Images.Count) % imgs.Images.Count;
            pbIcono.Image = imgs.Images[icono];
        }
        private void pbfondo_Click(object sender, EventArgs e)
        {
            colorSelec.ShowDialog();
            pbfondo.BackColor = colorSelec.Color;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.ImageIndex = icono;
            item.SubItems.Add(tbMinuto.Text);
            item.SubItems.Add(tbDesc.Text);
            item.BackColor = pbfondo.BackColor;
            lista.Items.Insert(0, item);
            this.Close();
        }


    }
}
