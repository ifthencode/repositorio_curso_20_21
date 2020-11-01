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

       // ListView lista;
        public FiltrarIncidencias(ListView lv)
        {
            InitializeComponent();
            lvFiltrado = lv;
        }
    }
}
