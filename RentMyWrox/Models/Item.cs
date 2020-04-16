using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentMyWrox.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public double Cost { get; set; }
        public DateTime? Checkout { get; set; }
        public DateTime? DueBack { get; set; }
        public DateTime DateAcquired { get; set; }
        public bool IsAvailable { get; set; }
    }
}