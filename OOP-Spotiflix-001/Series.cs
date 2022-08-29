namespace OOP_Spotiflix_001
{
    internal class Series : Data
    {
        public List<Episode> Episodes { get; set; } = new();
        public string GetLength()
        {
            return Length.ToString("hh:mm");
        }
        public string GetReleaseDate()
        {
            return ReleaseDate.ToString("D");
        }
    }
    internal class Episode : Data
    {
    }

}
