using ApiVendas.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Repositories
{
    public class BaseRepository
    {
        public static List<T> QuerySql<T>(string sql, object parameter = null)
        {
            List<T> orderDetail;
            using (var connection = new SqlConnection("Server =.\\sqlexpress;Database=Vendas;Trusted_Connection=True;"))
            {
                orderDetail = connection.Query<T>(sql,parameter).ToList();
            }
            return orderDetail;
        }
        public static void Command<T>(T objeto ,bool editar = false,object parameter = null) where T : BaseModel
        {
            using (var connection = new SqlConnection("Server =.\\sqlexpress;Database=Vendas;Trusted_Connection=True;"))
            {
                if (editar)
                    connection.Update(objeto);
                else
                    connection.Insert(objeto);
            }
            
        }
    }
}
