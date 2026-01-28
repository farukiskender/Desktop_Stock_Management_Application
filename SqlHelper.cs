using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Masaüstü_Stok_Yönetim_Uygulaması
{
    public class SqlHelper
    {
        // Bağlantı cümlesini App.config dosyasından okur
        private static string connectionString = ConfigurationManager.ConnectionStrings["ErpBaglantisi"].ConnectionString;

        public static SqlConnection BaglantiGetir()
        {
            return new SqlConnection(connectionString);
        }
    }
}
