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
        string connectionString ="test"; //vi pratar med vår lokala server vi öppnat genom MAMP

        public List<Album> getAllAlbums()
        {
            //starta med en tom lista, Vi queryar till info i nedan lista och returnar sedan dessa till listan 
            List<Album> returnThese = new List<Album>();

            //koppla ihop till mySQL server, vi använder inte SQL Server. Vi använder MySQL

            MySqlConnection connection = new MySqlConnection(connectionString); //koppla till din server 
            connection.Open();

            return returnThese;
        }
    }
}
