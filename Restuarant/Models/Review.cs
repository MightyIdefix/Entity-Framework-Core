using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restuarant.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public string ReviewerName { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int Stars { get; set; }
        public string Text { get; set; }
        public int RestaurantId { get; set; }
        public int GuestId { get; set; }
        public int DishId { get; set; }

        public virtual RestaurantClass Restaurant { get; set; }
        public virtual List<ReviewGuest> ReviewGuests { get; set; }
        public virtual List<ReviewDish> ReviewDishes { get; set; }
    }
}
