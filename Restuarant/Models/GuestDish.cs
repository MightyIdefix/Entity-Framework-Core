using System;
using System.Collections.Generic;
using System.Text;

namespace Restuarant.Models
{
    public class GuestDish
    {
        public Guest Guest { get; set; }
        public Dish Dish { get; set; }
        public int GuestId { get; set; }
        public int DishId { get; set; }
    }
}
