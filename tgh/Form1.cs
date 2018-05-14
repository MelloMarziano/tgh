using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tgh.Views;

namespace tgh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrada frm = new Entrada();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salida frm = new Salida();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nuevoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicios frm = new Servicios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mecanicos frm = new Mecanicos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario frm = new Inventario();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
