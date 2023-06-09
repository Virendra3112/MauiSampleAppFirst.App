﻿using MauiSampleAppFirst.Models;
using SQLite;

namespace MauiSampleAppFirst.Helpers
{
    public static class SQLiteHelper
    {
        public static SQLiteAsyncConnection Database;

        public static async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(AppConstants.DatabasePath, AppConstants.Flags);
            var result = await Database.CreateTableAsync<Player>();
         }
    }
}
