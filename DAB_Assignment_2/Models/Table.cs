using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAB_Assignment_2.Models
{
    public class Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TableId { get; set; }
        public int WaiterId { get; set; }
        public int RestaurantId { get; set; }
        //public virtual List<Review> Reviews { get; set; }
        public virtual List<Guest> Guests { get; set; }
        public virtual Waiter Waiter { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
