using System;

namespace MyZoo.Models
{
    public class BookingInfo
    {
        public int VetId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int AnimalId { get; set; }
    }
}
