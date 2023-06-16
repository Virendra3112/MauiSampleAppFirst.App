using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSampleAppFirst.Helpers
{
    public class SQLiteOperations<T> : ISQLiteOperations<T>
    {
        public T GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
