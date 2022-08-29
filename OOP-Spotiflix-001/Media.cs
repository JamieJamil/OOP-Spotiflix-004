namespace OOP_Spotiflix_001
{
    internal class Media
    {
        #region Data/Inputs
        #region SaveData
        public Data data = new Data();

        protected void SaveData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = System.Text.Json.JsonSerializer.Serialize(data);
            File.WriteAllText(path + @"/SpotiflixData.json", json);
            Console.WriteLine("File saved succesfully in " + path);
            Console.Write("Press ANY button to go back to continue....");
            Console.ReadKey();
        }

        protected void LoadData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = File.ReadAllText(path + @"/SpotiflixData.json");
            data = System.Text.Json.JsonSerializer.Deserialize<Data>(json);
            Console.WriteLine("File loaded succesfully from " + path);
            Console.Write("Press ANY button to go back to continue....");
            Console.ReadKey();
        }
        #endregion
        #region Length
        protected DateTime GetLength()
        {
            DateTime to;
            do
            {
                Console.Write("\n[HH:MM:SS]\nMovie length: ");

            }
            while (!DateTime.TryParse("01-01-0001 " + Console.ReadLine(), out to));
            return to;
        }
        #endregion
        #region Release
        protected DateTime GetReleaseDate()
        {
            DateTime dateOnly;
            do
            {
                Console.Write("\nDD/MM/YYYY\nRelease date: ");
            }
            while (!DateTime.TryParse(Console.ReadLine(), out dateOnly));
            return dateOnly;
        }
        #endregion
        #region GetString
        protected string GetString(string type)
        {
            string? input;
            do
            {
                Console.Write(type);
                input = Console.ReadLine();
            }
            while (input == null || input == "");
            return input;
        }
        #endregion
        #region GetInt
        protected int GetInt(string request)
        {
            int i;
            do
            {
                Console.Write(request);
            }
            while (!int.TryParse(Console.ReadLine(), out i));
            return i;
        }
        #endregion
        #endregion
    }
}
