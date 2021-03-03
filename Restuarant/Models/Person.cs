using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restuarant.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

        public virtual Waiter Waiter { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
