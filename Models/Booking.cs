namespace CineMasterTemuV1._1._0.Models
{
    internal class Booking
    {
        public string BookingNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public Movie Movie { get; set; }
        public byte CustomerAge { get; set; }
        public int BookCount { get; set; }
    }
}
