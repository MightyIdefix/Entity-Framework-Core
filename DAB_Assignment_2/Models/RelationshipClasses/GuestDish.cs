using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAB_Assignment_2.RelationshipClasses
{
    public class GuestDish
    {
        public Guest Guest { get; set; }
        public Dish Dish { get; set; }
        public int GuestId { get; set; }
        public int DishId { get; set; }
    }
}
