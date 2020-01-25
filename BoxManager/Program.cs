using BoxManager.Model;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());

            var _connection = ConfigurationManager.ConnectionStrings["sql_server_connection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(_connection))
            {
                var box = new Box() { Label = "Teste", FullnessPercentage = 0 };
                var id = conn.Insert(box);
            }
        }
    }
}
