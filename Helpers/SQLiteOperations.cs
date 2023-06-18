using SQLite;

namespace MauiSampleAppFirst.Helpers
{
    public class SQLiteOperations<T> : ISQLiteOperations<T> where T : class, new()
    {
        SQLiteHelper SQLiteHelper;

        public SQLiteOperations()
        {
            SQLiteHelper = new SQLiteHelper();
        }



        public async Task<List<T>> GetAllAsync()
        {
            await SQLiteHelper.Init();
            return await SQLiteHelper.Database.Table<T>().ToListAsync();
        }

        public async Task<int> InsertAsync(T entity)
        {
            await SQLiteHelper.Init();
            return await SQLiteHelper.Database.InsertAsync(entity);
        }

        public async Task<int> DeleteAsync(T entity)
        {
            await SQLiteHelper.Init();
            return await SQLiteHelper.Database.UpdateAsync(entity);
        }
    }
}
