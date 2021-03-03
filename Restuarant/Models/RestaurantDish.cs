using System;
using System.Collections.Generic;
using System.Text;

namespace Restuarant.Models
{
    public class RestaurantDish
    {
        public RestaurantClass Restaurant { get; set; }
        public Dish Dish { get; set; }
        public int RestaurantId { get; set; }
        public int DishId { get; set; }
    }
}
