namespace MauiSampleAppFirst.Helpers
{
    public interface ISQLiteOperations<T> where T : class, new()
    {
        /// <summary>
        /// Get all Items
        /// </summary>
        /// <param name="entity">Entity or item model</param>
        /// <returns>List of items</returns>       
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// Insert Item
        /// </summary>
        /// <param name="entity">Entity or item model</param>
        /// <returns>The numbers of rows updated</returns>       
        Task<int> InsertAsync(T entity);

        /// <summary>
        /// Dalete Item
        /// </summary>
        /// <param name="entity">Entity or item model</param>
        /// <returns>The numbers of rows updated</returns>       
        Task<int> DeleteAsync(T entity);

        /// <summary>
        /// Update Item
        /// </summary>
        /// <param name="entity">Entity or item model</param>
        /// <returns>The numbers of rows updated</returns>       
        Task<int> UpdateAsync(T entity);

        /// <summary>
        /// Query to table
        /// </summary>
        /// <param name="entity">Entity or item model</param>
        /// <param name="query">Query</param>
        /// <param name="param">Parameters</param>
        /// <returns>Item or list of items</returns>
        Task<List<T>> QueryAsync(T entity, string query, object[] param);

        /// <summary>
        /// Get item 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Item</returns>
        Task<T> GetItemAsync(T entity);

        /// <summary>
        ///Get item by Id
        /// </summary>
        /// <param name="id">Primary key of table</param>
        /// <returns>Item</returns>
        Task<T> GetItemById(int id);
    }
}
