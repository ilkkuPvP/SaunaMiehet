using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Omaprojekti
{
    class Uudenkäyttäjänteko
    {
        YhdistäSQL yhteys = new YhdistäSQL();
        public bool käyttis(string käyttäjä, string Salasana)
        {

            MySqlCommand cmd = new MySqlCommand("select * from kirjautuminen where Käyttäjä = @käyt and Salasana = @San", yhteys.otaYhteys());




            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            cmd.Parameters.Add("@käyt", MySqlDbType.VarChar).Value = käyttäjä;
            cmd.Parameters.Add("@San", MySqlDbType.VarChar).Value = Salasana;
            da.SelectCommand = cmd;

            da.Fill(ds);
            yhteys.suljeYhteys();

            bool Kirjautumisyritys = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            if (Kirjautumisyritys)
            {
                return true;





            }
            else
            {
                return false;

            }
        }
    }
}
