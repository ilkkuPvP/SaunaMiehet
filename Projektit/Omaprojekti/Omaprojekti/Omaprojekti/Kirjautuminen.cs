using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Omaprojekti
{

    class Kirjautuminen
    {
        // 
        YhdistäSQL yhdistäminen = new YhdistäSQL();

        public bool kirjautumistiedot(string käyttäjätunnus, string salasana)
        {

            MySqlCommand komento = new MySqlCommand();
            string lisäyskysely = "INSERT INTO kirjautuminen " +
                "(Käyttäjä, Salasana) " +
                "VALUES (@käyt, @sala); ";
            komento.CommandText = lisäyskysely;
            komento.Connection = yhdistäminen.otaYhteys();


            komento.Parameters.Add("@käyt", MySqlDbType.VarChar).Value = käyttäjätunnus;
            komento.Parameters.Add("@sala", MySqlDbType.VarChar).Value = salasana;

            yhdistäminen.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhdistäminen.suljeYhteys();
                return true;
            }
            else
            {
                yhdistäminen.suljeYhteys();
                return false;
            }


        }

    }
}
