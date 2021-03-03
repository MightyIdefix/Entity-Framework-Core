using System;
using System.Collections.Generic;
using System.Text;

namespace Restuarant.Models
{
    public class ReviewDish
    {
        public Review Review { get; set; }
        public Dish Dish { get; set; }
        public int ReviewId { get; set; }
        public int DishId { get; set; }
    }
}
