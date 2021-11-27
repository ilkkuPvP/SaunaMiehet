using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellityö
{
    public partial class Pää : Form
    {
        public Pää()
        {
            InitializeComponent();
        }

        private void ihmistentiedotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void huoneetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huoneet f2 = new Huoneet();
            f2.ShowDialog();

        }

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaukset f3 = new Varaukset();
            f3.ShowDialog();
        }
    }
}
