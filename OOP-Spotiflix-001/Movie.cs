using System.Globalization;

namespace OOP_Spotiflix_001
{
    internal class Movie : Data
    {
        public string GetLength()
        {
            return Length.ToString("HH:MM");
        }
        public string GetReleaseDate()
        {
            return ReleaseDate.ToString("D");
        }
    }
}
