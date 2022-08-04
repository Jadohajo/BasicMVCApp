namespace UdemyCourseFirstMVCApp.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }

        public string guestName { get; set; }
        
        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }
    }
}
