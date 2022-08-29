namespace OOP_Spotiflix_001
{
    internal class Song : Data
    {
        public string? GetReleaseDate()
        {
            return ReleaseDate.ToString("D");
        }
        public string? GetLength()
        {
            return Length.ToString("hh:mm");
        }
    }
    internal class Album : Data
    {
        public List<Song> Songs { get; set; } = new();
        public string? GetReleaseDate()
        {
            return ReleaseDate.ToString("D");
        }
    }
}
