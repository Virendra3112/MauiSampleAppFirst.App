using SQLite;

namespace MauiSampleAppFirst.Helpers
{
    public class SQLiteOperations<T> : ISQLiteOperations<T> where T : class, new()
    {
        SQLiteAsyncConnection DBConnection;

        public SQLiteOperations()
        {
            if (DBConnection is not null)
                return;

            DBConnection = new SQLiteAsyncConnection(AppConstants.DatabasePath, AppConstants.Flags);
        }



        public async Task<List<T>> GetAllAsync()
        {
            return await DBConnection.Table<T>().ToListAsync();
        }

        public async Task<int> InsertAsync(T entity)
        {
            return await DBConnection.InsertAsync(entity);
        }

        public async Task<int> DeleteAsync(T entity)
        {
            return await DBConnection.UpdateAsync(entity);
        }
    }
}
