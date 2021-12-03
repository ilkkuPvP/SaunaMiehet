using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Omaprojekti
{
    class Tunnuksenpoisto
    {
        YhdistäSQL yhteys = new YhdistäSQL();
        public bool Poisto(string käyttäjä, string Salasana)
        {

            MySqlCommand cmd = new MySqlCommand();



            string poistokysely = "DELETE FROM kirjautuminen where Käyttäjä = @käyt and Salasana = @San";



            cmd.Parameters.Add("@käyt", MySqlDbType.VarChar).Value = käyttäjä;
            cmd.Parameters.Add("@San", MySqlDbType.VarChar).Value = Salasana;
            cmd.CommandText = poistokysely;
            cmd.Connection = yhteys.otaYhteys();


            yhteys.avaaYhteys();
            if (cmd.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }


            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

    }
}
