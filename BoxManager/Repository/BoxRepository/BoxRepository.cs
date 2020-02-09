using BoxManager.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace BoxManager.Repository.BoxRepository
{
    public class BoxRepository : Repository<Box, int>
    {
        public IEnumerable<Item> GetAllItems(int boxId)
        {
            using (SqlConnection conn = new SqlConnection(_connection))
            {
                var query = @"select * from Item where Box_Id = " + boxId;
                return conn.Query<Item>(query);
            }
        }
    }
}
