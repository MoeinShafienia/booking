using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Salon
    {
        public int id { get; set; }
        public string name { get; set; }
        public double seatWeight { get; set; }
        public double seatHeight { get; set; }

        public IEnumerable<Show> shows { get; set; }

        public IEnumerable<Ticket> tickets { get; set; }

    }