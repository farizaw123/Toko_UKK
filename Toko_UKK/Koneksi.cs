using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Toko_UKK
{
    class Koneksi
    {
        public MySqlConnection GetConn()
        {
            MySqlConnection Conn = new MySqlConnection();
            Conn.ConnectionString = "server=localhost;user=root;password=;database=db_sekolah";
            return Conn;
        }
    }
}
