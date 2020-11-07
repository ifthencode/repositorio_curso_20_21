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
    public partial class FiltrarIncidencias : Form
    {
        ListViewItem[] itemlist;
        public FiltrarIncidencias(ListViewItem[] itemlist)
        {
            InitializeComponent();
            this.itemlist = itemlist;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {

            rellenar();
            
           
        }
        private void rellenar()
        {
            
            foreach (ListViewItem lo in itemlist)
            {
                if (lo!=null)
                {

                    ListViewItem lu = new ListViewItem();
                    lu.SubItems.Add(lo.SubItems[1]);
                    lu.SubItems.Add(lo.SubItems[2]);
                    lu.SubItems.Add(lo.SubItems[3]);
                    lu.SubItems.Add(lo.SubItems[4]);
                    lu.SubItems.Add(lo.SubItems[5]);
                    lu.SubItems.Add(lo.SubItems[6]);
                    int count = 0;
                    lvIncidenciasF.Items.Add(lu);
                    
                    
                }
                


            }

        }
    }
}
