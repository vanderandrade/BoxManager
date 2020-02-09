using BoxManager.Model;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace BoxManager.Repository
{
    public class Repository<T, Id> : IRepository<T, Id> where T : BasicId
    {
        protected readonly string _connection;

        public Repository()
        {
            if (System.IO.File.Exists(".connectionstring"))
                _connection = System.IO.File.ReadAllText(".connectionstring");
            else
                _connection = ConfigurationManager.ConnectionStrings["sql_server_connection"].ConnectionString;
        }

        public T GetById(Id id)
        {
            using (SqlConnection conexao = new SqlConnection(_connection))
                return conexao.Get<T>(id);
        }

        public void Delete (Id id)
        {
            T element = GetById(id);

            if (element is null) return;

            using (SqlConnection conn = new SqlConnection(_connection))
                conn.Delete(element);
        }

        public void Delete(T element)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
                conn.Delete(element);
        }

        public long Insert(T element)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
                return conn.Insert(element);
        }

        public IEnumerable<T> List()
        {
            using (SqlConnection conn = new SqlConnection(_connection))
                return conn.GetAll<T>();
        }

        public void Update(T element)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
                conn.Update<T>(element);
        }
    }
}
