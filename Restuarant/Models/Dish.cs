using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restuarant.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public int RestaurantId { get; set; }
        public virtual List<RestaurantDish> RestaurantDishes { get; set; }
        public virtual List<ReviewDish> ReviewDishes { get; set; }
        public virtual List<GuestDish> GuestDishes { get; set; }
    }
}
