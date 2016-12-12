using SQLite.Net;

namespace WhoAmI.data
{
    public interface ISQLiteConnectionPovider
    {
        SQLiteConnection GetConnection();
    }
}
