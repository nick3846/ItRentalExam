using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItRental.Entities
{
    public class Equipment
    {
        public int Id { get; set; }
        [Display(Name = "Navn")]
        public string Name { get; set; }
        [Display(Name = "Kategori")]
        public string Category { get; set; }
        [Display(Name = "Antal")]
        public int Units { get; set; }
    }
}
