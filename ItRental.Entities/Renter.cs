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
        public List<Renter> Rentals { get; set; }
        public int NumberOfRentals { get; }
        



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
