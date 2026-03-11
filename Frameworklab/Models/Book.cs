using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Frameworklab.Models
{
    [Table("Boooook")]
    internal class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }

        [Column("Bookprice")]
        public double Price { get; set; }
    }
}
