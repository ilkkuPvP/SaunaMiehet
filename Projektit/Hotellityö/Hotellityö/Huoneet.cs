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

    public partial class Huoneet : Form
    {
        public Huoneet()
        {
            InitializeComponent();
        }



        string Onko;
        string huone;

        toinen Uus = new toinen();
        private void button3_Click(object sender, EventArgs e)
        {
            if(Num.Text == "")
            {
                MessageBox.Show("Poistettavan huoneen numero täytyy mainita.", "Huoneen poistaminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Uus.poistaHuone(Num.Text);
                Taulu.DataSource = Uus.HaeOpiskelijahuoneista();

                Num.Text = "";
                Puhelin.Text = "";

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                Ei.Checked = false;
                Kyllä.Checked = false;
            }
        }

        private void Uusi_Click(object sender, EventArgs e)
        {
            if(Num.Text == "" || Puhelin.Text == "" || radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && Ei.Checked == false && Kyllä.Checked == false)
            {
                MessageBox.Show("Mainitsethan huoneen numeron, puhelinnumeron, onko huone varattu ja huoneen tyypin.", "Huoneen lisääminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Uus.Huone(Num.Text, huone, Puhelin.Text, Onko);
                Taulu.DataSource = Uus.HaeOpiskelijahuoneista();


                Num.Text = "";
                Puhelin.Text = "";

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                Ei.Checked = false;
                Kyllä.Checked = false;
            }
        }

        private void Huoneet_Load(object sender, EventArgs e)
        {
            Taulu.DataSource = Uus.HaeOpiskelijahuoneista();
        }

        private void Kyllä_CheckedChanged(object sender, EventArgs e)
        {
            Onko = "Kyllä";
        }

        private void Ei_CheckedChanged(object sender, EventArgs e)
        {
            Onko = "Ei";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            huone = "Yksiö";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            huone = "Kaksio";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            huone = "Perhe";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Päivitä_Click(object sender, EventArgs e)
        {
            Taulu.DataSource = Uus.HaeOpiskelijahuoneista();
        }

        private void Taulu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(Taulu.Rows[e.RowIndex].Cells[0].Value == null)
            {
                Num.Text = "";
                Puhelin.Text = "";

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                Ei.Checked = false;
                Kyllä.Checked = false;
                return;
            }
            else
            {
                Num.Text = Taulu.Rows[e.RowIndex].Cells[0].Value.ToString();
                Puhelin.Text = Taulu.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Taulu.Rows[e.RowIndex].Cells[3].Value.ToString() == "Kyllä")
                {
                    Kyllä.Checked = true;
                    Ei.Checked = false;
                }
                else
                {
                    Ei.Checked = true;
                    Kyllä.Checked = false;
                }

                if (Taulu.Rows[e.RowIndex].Cells[1].Value.ToString() == "Yksiö")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                }
                else if (Taulu.Rows[e.RowIndex].Cells[1].Value.ToString() == "Kaksio")
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                    radioButton3.Checked = false;
                }
                else
                {
                    radioButton3.Checked = true;
                    radioButton2.Checked = false;
                    radioButton1.Checked = false;
                }
            }
        }
    }
}
