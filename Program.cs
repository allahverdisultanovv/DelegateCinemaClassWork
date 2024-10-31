using CineMasterTemuV1._1._0.Models;

Movie movie1 = new("Venom", "Action", 15, 2.51, new DateTime(2024, 10, 15));
Movie movie2 = new("Deadpool", "Action", 18, 2.51, new DateTime(2008, 06, 12));
Movie movie3 = new("Pirates of Carabian", "Action", 10, 2.51, new DateTime(2015, 1, 15));
Movie movie4 = new("Fast & Furious", "Action", 7, 2.51, new DateTime(2020, 10, 15));
Movie movie5 = new("Central Intilligence", "War", 18, 2.51, new DateTime(2003, 04, 11));
Booking booking = new Booking()
{
    BookingNumber = "N№212",
    BookingDate = DateTime.Now,
    CustomerAge = 21,
    Movie = movie2,
    BookCount = 1
};
Booking booking2 = new Booking()
{
    BookingNumber = "N№21",
    BookingDate = DateTime.Now,
    CustomerAge = 15,
    Movie = movie1,
    BookCount = 2

};
Booking booking3 = new Booking()
{
    BookingNumber = "N№321",
    BookingDate = DateTime.Now,
    CustomerAge = 26,
    Movie = movie5,
    BookCount = 4

};
Booking booking4 = new Booking()
{
    BookingNumber = "N№14",
    BookingDate = DateTime.Now,
    CustomerAge = 18,
    Movie = movie4,
    BookCount = 7

};

List<Movie> movies = new List<Movie>() { movie1, movie2, movie3, movie4, movie5 };
List<Booking> bookings = new List<Booking>() { booking, booking2, booking3, booking4 };


Console.WriteLine("+18 filmler\n");

movies.FindAll(f => f.AgeLimit >= 18).ForEach(f => Console.WriteLine(f.Name));

Console.WriteLine("\niki saatdan uzun filmler\n");


movies.FindAll(f => f.Time >= 2).ForEach(f => Console.WriteLine(f.Name));


Console.WriteLine("\nSon bir ilde yayimlanan filmler\n");
movies.FindAll(f => f.ReleaseDate.AddYears(1) >= DateTime.Now).ForEach(f => Console.WriteLine(f.Name));


movies.RemoveAll(f => f.Genre == "Action");

Console.WriteLine("\nMusterinin yasi catmayan sifarisler\n");
bookings.FindAll(b => b.CustomerAge < b.Movie.AgeLimit).ForEach(b => Console.WriteLine(b.Movie.Name));


Console.WriteLine("\nSon bir ayda edilen resrvasialar\n");

bookings.FindAll(b => b.BookingDate.AddMonths(1) >= DateTime.Now).ForEach(b => Console.WriteLine(b.Movie.Name));



Console.WriteLine("\n3 den cox yer bron edilmis rezervasyonlar\n");

bookings.FindAll(b => b.BookCount > 3).ForEach(b => Console.WriteLine(b.BookingNumber + " " + b.Movie.Name + " " + b.BookCount));



void CheckMovieBooking(Movie movie)
{
    bookings.FindAll(b => b.Movie == movie).ForEach(b => Console.WriteLine(b.BookingNumber + " " + b.Movie.Name));
}
Console.WriteLine("\nBir filmin rezervleri\n");
CheckMovieBooking(movie2);



