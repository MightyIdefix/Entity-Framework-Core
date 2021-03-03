using DAB_Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAB_Assignment_2.RelationshipClasses
{
    public class ReviewGuest
    {
        public Guest Guest { get; set; }
        public int GuestId { get; set; }
        public Review Review { get; set; }
        public int ReviewId { get; set; }
    }
}
