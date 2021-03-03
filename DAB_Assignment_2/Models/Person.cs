using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAB_Assignment_2.Models
{
    public abstract class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonId { get; set; }
        public string Name { get; set; }
    }
}
