namespace OOP_Spotiflix_001
{
    internal class Gui : Media
    {
        public Gui()
        {

            //data.MovieList.Add(new Movie() { Title = "Rambo III", Genre = "Action", Length = new DateTime(1, 1, 1, 1, 42, 0), ReleaseDate = new DateTime(1988, 5, 25), WWW=@"https:\\Netflix.com"});
            while (true)
            {
                Menu();
            }
        }
        #region Menu
        private void Menu()
        {
            Console.Clear();
            Console.WriteLine("\nMENU\n1 for movies\n2 series\n3 music\n4 save\n5 Load");

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
            Console.WriteLine("\nMOVIE MENU\n1 for lsit of movies\n2 search\n3 add new");

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

            movie.Title = GetString("Adding new movie...\n\nTitle of the movie: ");
            movie.Length = GetLength();
            movie.Genre = GetString("\nGenre: ");
            movie.ReleaseDate = GetReleaseDate();
            movie.WWW = GetString("\nEnter web adresse: ");

            ShowMovie(movie);
            Console.WriteLine("Confirm adding to database Y/N");
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
            string? search = Console.ReadLine();
            foreach (Movie movie in data.MovieList)
            {
                if (search != null)
                {
                    if (movie.Title.Contains(search) || movie.Genre.Contains(search))
                    {
                        ShowMovie(movie);
                    }
                }
            }
        }
        private void ShowMovie(Movie m)
        {
            //Console.Clear();
            Console.WriteLine("\n[Search results]\nTitle - Genre - Length - Release date - Web Adresse");
            Console.WriteLine($"\n\n{m.Title} {m.GetLength()} {m.Genre} {m.GetReleaseDate()} {m.WWW}");
            Console.Write("\n\nPress ANY button to go back to Main Menu....");
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
            Console.WriteLine("\nSERIES MENU\n1 for list of series\n2 for search series\n3 for add new series");

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
            string? search = Console.ReadLine();
            foreach (Series series in data.SeriesList)
            {
                if (search != null)
                {
                    if (series.Title.Contains(search) || series.Genre.Contains(search))
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
                episode.Season = GetInt("Title: ");
                episode.EpisodeNumber = GetInt("Title: ");
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
            Console.WriteLine("\nMUSIC MENU\n1 for list of albums\n2 Search for album\n3 for add new album");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowMusicList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
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
            album.Title = GetString("Album name: ");
            album.Artist = GetString("Artists name: ");
            album.ReleaseDate = GetReleaseDate();

            ShowAlbum(album);
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.MusicList.Add(album);

            Console.WriteLine("Add songs to album? Y/N");
            do
            {
                AddSong(album);
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
            {
                AddSong(album);
                Console.WriteLine("Add another song?");
            }

        }
        private void ShowAlbum(Album album, bool showSongs = false)
        {
            //TODO show album detals
            Console.WriteLine($"\nAlbum Name: {album.Title} \nArtist: {album.Artist} \nReleasedate: {album.GetReleaseDate()}");
            if (showSongs)
            {
                foreach (Song song in album.Songs)
                {
                    ShowSong(song);
                }
            }
        }
        private void ShowSong(Song song)
        {
            //TODO Show song setails
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
