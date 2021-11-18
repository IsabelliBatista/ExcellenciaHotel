using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PIM_.Models
{
    public class Conexao
    {
        private static string Connection = @"Password=123456;Persist Security Info=True;User ID=isabelli;Initial Catalog=HotelariaExcellencia;Data Source=DESKTOP-N2K30DI\SQLSERVER";
    
        public static SqlConnection GetConnection()
        {
            var cn = new SqlConnection(Connection);
            return cn;
        }
    }
}
