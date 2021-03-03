using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restuarant.Models
{
    public class Waiter
    {
        public int WaiterId { get; set; }
        public string WaiterName { get; set; }
        public int Salary { get; set; }
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
        public virtual List<Table> Tables { get; set; }
    }
}
