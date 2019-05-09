using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItRental.Dal;
using ItRental.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItRental.Web.Pages
{
    public class RenterDetailsModel : PageModel
    {
        public RenterDetailsModel()
        {
            Equipments = EquipmentRepository.GetEquipments();
        }
        [BindProperty]
        public Rental Rental { get; set; } = new Rental();
        public RenterRepository RenterRepository { get; set; } = new RenterRepository();
        public EquipmentRepository EquipmentRepository { get; set; } = new EquipmentRepository();
        public RentalRepository RentalRepository { get; set; } = new RentalRepository();
        public Renter Renter { get; set; } = new Renter();
        public List<Rental> Rentals { get; set; } = new List<Rental>();
        public List<Equipment> Equipments { get; set; } = new List<Equipment>();
        public string ReturnLate { get; set; } = "";
        public void OnGet(int id)
        {
            Renter = RenterRepository.GetById(id);
            Rentals = RentalRepository.GetByRenterId(id);
            Renter.Rentals = Rentals;
        }
        public void OnPostInsert()
        {
            RentalRepository.Insert(Rental);
            Rentals = RentalRepository.GetByRenterId(Rental.Renter.Id);
        }
        public string IsRentalOverdue(DateTime date)
        {
            if (date < DateTime.Now)
            {
                return "rentalOverdue";
            }
            else
                return "";
        }
    }
}