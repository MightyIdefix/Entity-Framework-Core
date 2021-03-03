using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAB_Assignment_2.Models
{
    public class Waiter : Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WaiterId { get; set; }
        public int Salary { get; set; }
        public virtual List<Table> Tables { get; set; }
    }
}
