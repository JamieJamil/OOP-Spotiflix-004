﻿namespace OOP_Spotiflix_001
{
    internal class Series
    {
        public string? Title { get; set; }
        public DateTime Length { get; set; }
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? WWW { get; set; }
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
    internal class Episode
    {
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Season { get; set; }
        public int EpisodeNumber { get; set; }
        public DateTime Length { get; set; }
    }

}
