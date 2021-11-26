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
      

        private void Käyttäjätunnus_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salasana_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Uusisalasana_Click(object sender, EventArgs e)
        {
            if (Käyttäjätunnus.Text.Length > 0)
            {
                Uus.uusikäyttäjä(Käyttäjätunnus.Text, Salasana.Text);
                Käyttäjätunnus.Text = "";
                Salasana.Text = "";
            }
            else
            {
                MessageBox.Show("Kirjoita kenttään käyttäjätunnus ja salasana, niin ohjelma tekee uuudet tunnukset");
            }
            
        }

        private void Tarkistus_Click(object sender, EventArgs e)
        {
       
            if (Käyttäjätunnus.Text.Length > 0 && Salasana.Text.Length > 0)
            {
                if(Uus.käyttis(Käyttäjätunnus.Text, Salasana.Text) == true)
                {


                    MessageBox.Show("Kirjautuminen onnistui", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Salasana tai käyttäjätunnus on väärin, tee käyttäjätunnus, jos sinulle ei sitä vielä ole", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Käyttäjätunnus.Text = "";
                    Salasana.Text = "";

                }
             
                   
                   


              
            }
            
        }
    
    
      
    }
}
