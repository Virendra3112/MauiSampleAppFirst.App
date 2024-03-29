﻿namespace MauiSampleAppFirst.Helpers
{
    public class SQLiteOperations<T> : ISQLiteOperations<T> where T : class, new()
    {
        public async Task<List<T>> GetAllAsync()
        {
            return await SQLiteHelper.Database.Table<T>().ToListAsync();
        }

        public async Task<int> InsertAsync(T entity)
        {
            return await SQLiteHelper.Database.InsertAsync(entity);
        }

        public async Task<int> DeleteAsync(T entity)
        {
            return await SQLiteHelper.Database.DeleteAsync(entity);
        }

        public async Task<int> UpdateAsync(T entity)
        {
            return await SQLiteHelper.Database.UpdateAsync(entity);
        }
        public async Task<List<T>> QueryAsync(T entity, string query, object[] param)
        {
            return await SQLiteHelper.Database.QueryAsync<T>(query, param);
        }

        public async Task<T> GetItemAsync(T entity)
        {
            return await SQLiteHelper.Database.FindAsync<T>(entity);
        }

        public async Task<T> GetItemById(int id)
        {
            return await SQLiteHelper.Database.FindAsync<T>(id);
        }
    }
}
