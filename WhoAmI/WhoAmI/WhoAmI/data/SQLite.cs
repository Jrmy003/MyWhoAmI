using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoAmI.business;
using WhoAmI.helpers;

namespace WhoAmI.data
{
    public class SQLite
    {
        private static SQLite _instance;

        public static SQLite Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SQLite();
                return _instance;
            }
        }

        public void CreerTables()
        {
            var sqliteConnectionProvider = ServiceContainer.Resolve<ISQLiteConnectionPovider>();
            var connection = sqliteConnectionProvider.GetConnection();
            connection.CreateTable<Character>();
        }

    }
}
