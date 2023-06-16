using SQLite;

namespace MauiSampleAppFirst.Helpers
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection Database;

        public SQLiteHelper()
        {
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(AppConstants.DatabasePath, AppConstants.Flags);
            //var result = await Database.CreateTableAsync<TodoItem>();
        }
    }
}
