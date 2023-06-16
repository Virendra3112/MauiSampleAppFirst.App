namespace MauiSampleAppFirst.Helpers
{
    public interface ISQLiteOperations<T>
    {
        IEnumerable<T> GetItems();
        T GetItemById(int id);
    }
}
