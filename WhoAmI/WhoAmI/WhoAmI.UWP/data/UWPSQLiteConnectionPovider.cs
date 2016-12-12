using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System.IO;
using WhoAmI.data;

namespace WhoAmI.UWP.data
{
    class UWPSQLiteConnectionPovider : ISQLiteConnectionPovider
    {
        public SQLiteConnection GetConnection()
        {
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            return new SQLiteConnection(new SQLitePlatformWinRT(), path);
        }
    }
}
