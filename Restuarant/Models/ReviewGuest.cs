using System;
using System.Collections.Generic;
using System.Text;

namespace Restuarant.Models
{
    public class ReviewGuest
    {
        public Guest Guest { get; set; }
        public int GuestId { get; set; }
        public Review Review { get; set; }
        public int ReviewId { get; set; }
    }
}
