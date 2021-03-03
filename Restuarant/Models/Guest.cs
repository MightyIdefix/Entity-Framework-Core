using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restuarant.Models
{
    public class Guest
    {
        public int GuestId { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string GuestName { get; set; }
        public int PersonId { get; set; }
        public int TableId { get; set; }

        public virtual Table Table { get; set; }
        public virtual Person Person { get; set; }
        public virtual List<ReviewGuest> ReviewGuests { get; set; }
        public virtual List<GuestDish> GuestDishes { get; set; }
    }
}
