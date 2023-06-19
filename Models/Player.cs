using SQLite;

namespace MauiSampleAppFirst.Models
{
    public class Player
    {
        [AutoIncrement, PrimaryKey]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerImage { get; set; }
        public string Country { get; set; }
    }
}
