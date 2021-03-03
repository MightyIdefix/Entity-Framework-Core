using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DAB_Assignment_2.RelationshipClasses;

namespace DAB_Assignment_2.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double AverageRating { get; set; }
        public string Type { get; set; }

        public virtual List<Table> Tables { get; set; }
        public virtual List<RestaurantDish> RestaurantDishes { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
