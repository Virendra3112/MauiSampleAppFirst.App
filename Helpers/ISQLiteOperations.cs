namespace MauiSampleAppFirst.Helpers
{
    public interface ISQLiteOperations<T> where T : class, new()
    {
        Task<List<T>> GetAllAsync();

        Task<int> InsertAsync(T entity);

        Task<int> DeleteAsync(T entity);

        Task<int> UpdateAsync(T entity);
        Task<List<T>> QueryAsync(T entity, string query, object[] param);

        Task<T> GetItemAsync(T entity);


    }
}
