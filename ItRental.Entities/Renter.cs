using System;
using System.Collections.Generic;
using System.Text;

namespace ItRental.Entities
{
    public class Renter
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
