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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Uusikäyttis Uus = new Uusikäyttis();

        private void Salasana_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Uusisalasana_Click(object sender, EventArgs e)
        {
            if (Käyttäjätunnus.Text != "" && Salasana.Text != "")
            {
                Uus.uusikäyttäjä(Käyttäjätunnus.Text, Salasana.Text);
                MessageBox.Show("Rekisteröityminen onnistui, voit nyt kirjautua sisään.", "Rekisteröityminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Käyttäjätunnus.Text = "";
                Salasana.Text = "";
            }
            else
            {
                //  "Kirjoita kenttään käyttäjätunnus ja salasana, niin ohjelma tekee uuudet tunnukset"
                MessageBox.Show("Käyttäjätunnus tai salasana puuttuu", "Rekisteröityminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Tarkistus_Click(object sender, EventArgs e)
        {
       
            if (Käyttäjätunnus.Text != "" && Salasana.Text != "")
            {
                if(Uus.käyttis(Käyttäjätunnus.Text, Salasana.Text) == true)
                {


                    MessageBox.Show("Kirjautuminen onnistui", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Pää f1 = new Pää();
                    f1.Show();
                    
                    
                    
                    //Form2 form2 = (Form2)Application.OpenForms["Form2"];
                    //form2.Close();
                }
                else
                {
                    MessageBox.Show("Käyttäjätunnus tai salasana virheellinen. Rekisteröidy, jos sinulla ei vielä ole tunnuksia.", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Käyttäjätunnus.Text = "";
                    Salasana.Text = "";

                }
             
            }
            else
            {
                MessageBox.Show("Käyttäjätunnus tai salasana virheellinen. Rekisteröidy, jos sinulla ei vielä ole tunnuksia.", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Käyttäjätunnus.Text = "";
                Salasana.Text = "";
            }
            
        }
    }
}
