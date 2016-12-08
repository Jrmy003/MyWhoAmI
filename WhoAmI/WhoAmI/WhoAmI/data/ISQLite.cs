using SQLite.Net;

namespace WhoAmI.data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
