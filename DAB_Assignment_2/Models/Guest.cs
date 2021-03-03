﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DAB_Assignment_2.RelationshipClasses;

namespace DAB_Assignment_2.Models
{
    public class Guest : Person
    {
        public int GuestId { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
        public virtual List<ReviewGuest> ReviewGuests { get; set; }
        public virtual List<GuestDish> GuestDishes { get; set; }
    }
}
