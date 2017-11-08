using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Models
{
    public class AnimalInfo
    {
        public int Id { get; set; }
        public decimal? Weight { get; set; }
        public string Species { get; set; }
        public string Enviorment { get; set; }
        public string FoodType { get; set; }
        public string Country { get; set; }
        public int Parent1Id { get; set; }
        public int Parent2Id { get; set; }
    }
}
