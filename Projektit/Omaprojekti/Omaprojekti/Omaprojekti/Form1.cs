using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omaprojekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kirjautuminen kirjautuminen = new Kirjautuminen();
        Uudenkäyttäjänteko Teko = new Uudenkäyttäjänteko();

        private void RekisteröityminenBT_Click(object sender, EventArgs e)
        {
            RekisteröidyPanel.Visible = true;
        }

        private void TakaisinPanelBT_Click(object sender, EventArgs e)
        {
            RekisteröidyPanel.Visible = false;
        }

        private void RekisteröidyPanelBT_Click(object sender, EventArgs e)
        {
            if (KäyttäjäPanelTB.Text != "" || SalasanaPanelTB.Text != "")
            {
                kirjautuminen.kirjautumistiedot(KäyttäjäPanelTB.Text, SalasanaPanelTB.Text);
                MessageBox.Show("Käyttäjä tehty");
                RekisteröidyPanel.Visible = false;
            }

        } 

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            if (Teko.käyttis(KäyttäjäTB.Text, SalasanaTB.Text) == true)
            {
                MessageBox.Show("Kirjautuminen onnistui");
            }
            else
            {
                MessageBox.Show("Kirjautuminen epäonnistui");
            }
        }
    }
}
