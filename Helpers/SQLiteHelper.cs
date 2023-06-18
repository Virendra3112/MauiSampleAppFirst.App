using SQLite;

namespace MauiSampleAppFirst.Helpers
{
    public class SQLiteHelper
    {
        public static SQLiteAsyncConnection Database;

        public SQLiteHelper()
        {
        }

        public async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(AppConstants.DatabasePath, AppConstants.Flags);
            //var result = await Database.CreateTableAsync<TodoItem>();
        }
    }
}
