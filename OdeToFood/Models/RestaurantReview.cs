using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int id { get; set; }

        public string name { get; set; }

        public string city { get; set; }

        public string country { get; set; }

        public int Rating { get; set; }
    }
}
