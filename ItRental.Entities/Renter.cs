using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItRental.Entities
{
    public class Renter
    {
        public int Id { get; set; }
        [Display(Name="Navn")]
        public string Name { get; set; }
        [Display(Name="Rettigheder")]
        public RenterLevel RenterLevel { get; set; }
        public List<Rental> Rentals { get; set; } = new List<Rental>();
        public int NumberOfRentals { get
            {
                return Rentals.Count;
            }
        }


        public Renter NextRentalDue()
        {
            Renter rental = new Renter();

            return null;
        }
        public bool GetOverdueRental()
        {
            return false;
        }
    }
}
