using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Obsługa_biurowca
{
    class DB_Connection
    {
        public static SqlConnection polacz()
        {
            try
            {
                SqlConnection objPolaczenie = new SqlConnection();
                objPolaczenie.ConnectionString = "Data Source=KAROLINA\\SQL;Initial Catalog=Biurowiec;Integrated Security=True";
                objPolaczenie.Open();
                return objPolaczenie;
            }
            catch (Exception s)
            {
                return null;
            }
        }
    }
}
