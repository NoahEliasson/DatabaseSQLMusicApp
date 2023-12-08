using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLMusicApp
{
    public class AlbumsDOA
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music;"; //vi pratar med vår lokala server vi öppnat genom MAMP

        public List<Album> getAllAlbums()
        {
            //starta med en tom lista, Vi queryar till info i nedan lista och returnar sedan dessa till listan 
            List<Album> returnThese = new List<Album>();

            //koppla ihop till mySQL server, vi använder inte SQL Server. Vi använder MySQL

            MySqlConnection connection = new MySqlConnection(connectionString); //koppla till din server 
            

           // MySqlCommand command = new MySqlCommand("SELECT * FROM albums;");

            ///using (MySqlDataReader reader = command.ExecuteReader())
            //{
               // while (reader.Read())
               // {
                    //Album a = new Album();
                   // {
                      //  ID = reader.GetInt32(0),
                     //   AlbumName = reader.GetString(1),
                     //  ArtistName = reader.GetString(2),
                     //   Year = reader.GetInt32(3),
                     //   ImageURL = reader.GetString(4),
                   //     Description = reader.GetString(5)
                 //   };
               //     returnThese.Add(a);
             //   }
           /// }


            return returnThese;
        }
    }
}
