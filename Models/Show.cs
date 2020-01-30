using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Show
    {   
        public int id { get; set; }
        public string title { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string summery { get; set; }
        public decimal price { get; set; }

        public Salon salon { get; set; }
        public int salonId { get; set; }

        public IEnumerable<Ticket> tickets { get; set; }
    }