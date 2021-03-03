using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAB_Assignment_2.RelationshipClasses
{
    public class RestaurantDish
    {
        public Restaurant Restaurant { get; set; }
        public Dish Dish { get; set; }
        public int RestaurantId { get; set; }
        public int DishId { get; set; }
    }
}
