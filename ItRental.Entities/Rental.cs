using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItRental.Entities
{
    public class Rental : IComparable
    {
        public int Id { get; set; }

        [Display(Name ="Dato for lån")]
        public DateTime RentalTime { get; set; }

        [Display(Name ="Returnerings dato")]
        public DateTime ReturnTime { get; set; }

        public Equipment Equipment { get; set; }

        [Display(Name="Antal")]
        public int Units { get; set; }

        [Display(Name ="Låner")]
        public Renter Renter { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public bool IsRentalOverdue()
        {
            if (ReturnTime > DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
