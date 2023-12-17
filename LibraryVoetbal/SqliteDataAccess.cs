using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
namespace LibraryVoetbal
{
    public class SqliteDataAccess
    {
        public static List<Uitslag> LoadUitslagen()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Uitslag>("select * from Uitslagen", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Team> loadTeams()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Team>("select * from Teams", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveUitslag(Uitslag uitslag)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Uitslagen (thuisPloeg,doelpuntenThuis,uitPloeg,doelpuntenUit) values(@thuisPloeg, @doelpuntenThuis, @uitPloeg, @doelpuntenUit)", uitslag);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


    }
}
