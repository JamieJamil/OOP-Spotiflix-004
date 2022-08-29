namespace OOP_Spotiflix_001
{
    internal class Data
    {
        #region Lists
        public List<Movie> MovieList { get; set; } = new();
        public List<Series> SeriesList { get; set; } = new();
        public List<Album> MusicList { get; set; } = new();
        #endregion
        #region GetSets
        public string? Title { get; set; }
        public DateTime Length { get; set; }
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? WWW { get; set; }
        public string? Artist { get; set; }
        public int Season { get; set; }
        public int EpisodeNumber { get; set; }
        #endregion
    }
}
