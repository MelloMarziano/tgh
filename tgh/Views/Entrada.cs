using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tgh.Views
{
    public partial class Entrada : Form
    {
        
        public Entrada()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            for (int i = 1980; i <= 2020; i++)
            {
                cboAños.Items.Insert (0,i.ToString());
            }
        }
    }
}
