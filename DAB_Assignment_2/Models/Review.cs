using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DAB_Assignment_2.RelationshipClasses;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAB_Assignment_2.Models
{
    public class Review
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReviewId { get; set; }
        public string ReviewerName { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string DishName { get; set; }
        public int Stars { get; set; }
        public string Text { get; set; }
        public int RestaurantId { get; set; }
        public int GuestId { get; set; }
        public int DishId { get; set; }
        //public int TableId { get; set; }
        //public virtual Table Table { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual List<ReviewGuest> ReviewGuests { get; set; }
        public virtual List<ReviewDish> ReviewDishes { get; set; }
    }
}
