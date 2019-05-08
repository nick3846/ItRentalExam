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
    public class RentersModel : PageModel
    {
        public RentersModel()
        {
            Renters = RenterRepository.GetRenters();
        }
        [BindProperty]
        public Renter Renter { get; set; } = new Renter();
        public List<Renter> Renters { get; set; } = new List<Renter>();
        RenterRepository RenterRepository { get; set; } = new RenterRepository();

        public void OnGet()
        {
            
        }
        public void OnPostInsert()
        {
            RenterRepository.Insert(Renter);
            Renters.Add(Renter);
        }
    }
}