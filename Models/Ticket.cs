public class Ticket
    {
        public int userId { get; set; }
        
        public Salon salon { get; set; }
        public int showId { get; set; }

        public Seat seat { get; set; }
        public int seatId { get; set; }
    }