namespace OOP_Spotiflix_001
{
    internal class Song
    {
        public string? SongName { get; set; }
        public string? Artist { get; set; }
        public string? Genre { get; set; }
        public DateTime Length { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? WWW { get; set; }
    }
    internal class Album
    {
        public string? AlbumName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime Length { get; set; }
        public List<Series> Songs { get; set; } = new();

    }
}
