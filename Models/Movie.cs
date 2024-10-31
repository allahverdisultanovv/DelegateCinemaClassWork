namespace CineMasterTemuV1._1._0.Models
{
    internal class Movie
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public byte AgeLimit { get; set; }
        public double Time { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Movie(string name, string genre, byte ageLimit, double time, DateTime releaseDate)
        {
            Name = name;
            Genre = genre;
            AgeLimit = ageLimit;
            Time = time;
            ReleaseDate = releaseDate;
        }
    }


}
