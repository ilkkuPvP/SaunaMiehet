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

namespace Hotellityö
{
    class Uusikäyttis
    {

        string käyttäjätunnus = "root";
        string salainensana = "";
        Class1 yhteys = new Class1();
      
      public bool uusikäyttäjä(string käyttäjä, string salasana)
        {

            //MySqlCommand tappaminen = new MySqlCommand();
         

            MySqlCommand komento = new MySqlCommand();



            string lisäyskysely = "INSERT INTO käyttäjät " +
              "(käyttäjä, salasana) " +
              "VALUES (@käyt, @sala)  ";

            käyttäjätunnus = "Select * FROM käyttäjät WHERE Käyttäjä = @käyt";
            salainensana = "Select * FROM käyttäjät WHERE Salasana = @sala";

            komento.CommandText = lisäyskysely;
            komento.Connection = yhteys.otaYhteys();


            komento.Parameters.Add("@käyt", MySqlDbType.VarChar).Value = käyttäjä;
            komento.Parameters.Add("@sala", MySqlDbType.VarChar).Value = salasana;
            






            yhteys.avaaYhteys();


            if (komento.ExecuteNonQuery() == 1)
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

        public bool käyttis(string käyttäjä, string Salasana)
        {

            MySqlCommand cmd = new MySqlCommand("select * from käyttäjät where Käyttäjä = @käyt and Salasana = @San", yhteys.otaYhteys());
     
            


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

        /*
public bool testi()
        {
       
            return true;
        }
        */
    
        public bool käyttäjä(string käyttäjä, string salasana) 
        {
            if(käyttäjä == käyttäjätunnus && salasana == salainensana)
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
