namespace OOP_Spotiflix_001
{
    internal class Gui : Media
    {
        public Gui()
        {

            // data.MovieList.Add(new Movie() { Title = "Rambo III", Genre = "Action", Length = new DateTime(1, 1, 1, 1, 42, 0), ReleaseDate = new DateTime(1988, 5, 25), WWW=@"https:\\Netflix.com"});
            while (true)
            {
                Menu();
            }
        }
        #region Menu
        private void Menu()
        {
            Console.Clear();
            Console.WriteLine("\nMAIN MENU\n\n[1] MOVIES\n[2] SERIES\n[3] MUSIC\n\n[4] SAVE\n[5] LOAD");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    MovieMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SeriesMenu();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    MusicMenu();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    SaveData();
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    LoadData();
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region Movie
        private void MovieMenu()
        {
            Console.Clear();
            Console.WriteLine("\nMOVIE MENU\n[1] To See List Of Movies\n[2] To Search For A Movie\n[3] To Add New Movie");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowMovieList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SearchMovie();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    AddMovie();
                    break;
                default:
                    break;
            }
        }
        private void AddMovie()
        {
            Movie movie = new Movie();
            Console.Clear();
            movie.Title = GetString("Adding new movie...\n\nTitle of the movie: ");
            movie.Genre = GetString("\nGenre: ");
            movie.Length = GetLength();
            movie.ReleaseDate = GetReleaseDate();
            movie.WWW = GetString("\nWebsite: ");

            ShowMovie(movie);
            Console.WriteLine("Confirm adding to list (Y/N)");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Y:
                    data.MovieList.Add(movie);
                    break;
                default:
                    break;
            }
        }
        private void SearchMovie()
        {
            Console.Write("Search for a movie name or genre: ");
            string? search = Console.ReadLine().ToLower();
            foreach (Movie movie in data.MovieList)
            {
                if (search != null)
                {
                    if (movie.Title.ToLower().Contains(search) || movie.Genre.ToLower().Contains(search))
                    {
                        ShowMovie(movie);
                    }
                }
            }
        }
        private void ShowMovie(Movie m)
        {
            //Console.Clear();
            Console.WriteLine($"\nTitle: {m.Title} \nGenre: {m.Genre} \nLength: {m.GetLength()} \nReleasedate: {m.GetReleaseDate()} \nWebsite: {m.WWW}");
        }
        private void ShowMovieList()
        {
            foreach (Movie m in data.MovieList)
            {
                ShowMovie(m);
            }
            Console.ReadKey();
        }
        #endregion
        #region Series
        private void SeriesMenu()
        {
            Console.WriteLine("\nSERIES MENU\n[1] To See List Of Series\n[2] To Search For A Series\n[3] To Add New Series");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowSeriesList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SearchSeries();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    AddSeries();
                    break;
                default:
                    break;
            }
        }
        private void AddSeries()
        {
            Console.Clear();
            Series series = new Series();
            series.Title = GetString("Adding new series...\n\nTitle of series: ");
            series.Genre = GetString("Genre: ");
            series.ReleaseDate = GetReleaseDate();
            series.WWW = GetString("WWW: ");

            ShowSeries(series);
            Console.WriteLine("\n\nConfirm adding to list (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.SeriesList.Add(series);

            Console.WriteLine("Add episode? Y/N");
            while (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                AddEpisode(series);
            }
        }
        private void SearchSeries()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine().ToLower();
            foreach (Series series in data.SeriesList)
            {
                if (search != null)
                {
                    if (series.Title.ToLower().Contains(search) || series.Genre.ToLower().Contains(search))
                        ShowSeries(series);
                }
            }
        }
        private void ShowSeries(Series s)
        {
            Console.Clear();
            Console.WriteLine($"\nTitle: {s.Title} \nGenre: {s.Genre} \nReleasedate: {s.GetReleaseDate()} \nWebsite: {s.WWW}");
        }

        private void ShowSeriesList()
        {
            foreach (Series s in data.SeriesList)
            {
                ShowSeries(s);
            }
        }
        private void AddEpisode(Series series)
        {
            do
            {
                Episode episode = new Episode();
                episode.Title = GetString("Title: ");
                episode.Season = GetInt("Season: ");
                episode.EpisodeNumber = GetInt("Episode Number: ");
                episode.Length = GetLength();
                episode.ReleaseDate = GetReleaseDate();


                Console.WriteLine("Add another episode? Y/N");
                if (Console.ReadKey().Key == ConsoleKey.Y) series.Episodes.Add(episode);
                Console.WriteLine("Confirm adding to list (Y/N)");
            }
            while (Console.ReadKey().Key == ConsoleKey.Y);
        }
        #endregion
        #region Music
        private void MusicMenu()
        {
            Console.Clear();
            Console.WriteLine("\nMUSIC MENU\n[1] To See List Of Albums\n[2] To Search For An Album\n[3] To Add New Album");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowMusicList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SearchAlbum();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    AddAlbum();
                    break;
                default:
                    break;
            }
        }
        private void AddAlbum()
        {
            Album album = new Album();
            Console.Clear();
            album.Title = GetString("Adding new album...\n\nName of the album: ");
            album.Artist = GetString("Artists name: ");
            album.ReleaseDate = GetReleaseDate();

            ShowAlbum(album);
            Console.WriteLine("\n\nConfirm adding to list (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.MusicList.Add(album);

            Console.WriteLine("Add songs to album? (Y/N)");
            do
            {
                AddSong(album);
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
            {
                AddSong(album);
                Console.WriteLine("Add another song? (Y/N)");
            }

        }
        private void ShowAlbum(Album album, bool showSongs = false)
        {
            Console.WriteLine($"\nAlbum Name: {album.Title} \nArtist: {album.Artist} \nReleasedate: {album.GetReleaseDate()}");
            if (showSongs)
            {
                foreach (Song song in album.Songs)
                {
                    ShowSong(song);
                }
            }
        }
        private void SearchAlbum()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine().ToLower();
            foreach (Album album in data.MusicList)
            {
                if (search != null)
                {
                    if (album.Title.ToLower().Contains(search) || album.Artist.ToLower().Contains(search))
                        ShowAlbum(album);
                }
            }
        }
        private void ShowSong(Song song)
        {
            Console.WriteLine($"\nSong Title: {song.Title} \nArtist: {song.Artist} \nReleasedate: {song.GetReleaseDate()} \nReleasedate: {song.GetLength()}");
            
        }
        private void AddSong(Album album)
        {
            Song song = new Song();
            song.Title = GetString("Tittle: ");
            song.Artist = GetArtist(album.Artist,"Artist: ");
            song.ReleaseDate = GetReleaseDate();
            song.Length = GetLength();

            Console.WriteLine("Add song to album?");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) album.Songs.Add(song);

        }
        private string GetArtist(string? artist, string type)
        {
            Console.Write(type);
            string input = Console.ReadLine();
            if (input == "") artist = input;
            return artist;
        }
        private void ShowMusicList()
        {
            foreach (Album album in data.MusicList)
            {
                ShowAlbum(album, true);
            }
        }
        #endregion
    }
}
