using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItRental.Entities
{
    public class Rental : IComparable
    {
        public int Id { get; set; }
        public DateTime RentalTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public Equipment Equipment { get; set; }
        [Display(Name="Antal")]
        public int Units { get; set; }
        public Renter Renter { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public bool IsRentalOverdue()
        {
            return false;
        }
    }
}
