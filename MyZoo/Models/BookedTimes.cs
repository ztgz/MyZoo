using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Models
{
    public class BookedTimes
    {
        public int BookingId { get; set; }
        public int AnimalId { get; set; }
        public int VeterinaryId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
