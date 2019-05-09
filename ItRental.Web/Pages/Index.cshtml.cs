using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItRental.Dal.Services;
using ItRental.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItRental.Web.Pages
{
    public class IndexModel : PageModel
    {
        public OpeningHoursInfo OpeningHoursInfo { get; set; }
        public IsOpenInfo IsOpenInfo { get; set; }
        public string Open { get; set; } = "Lukket";
        public void OnGet()
        {
            OpeningHoursService openingHoursService = new OpeningHoursService();
            OpeningHoursInfo = openingHoursService.GetOpeningHours();

            IsOpenService isOpenService = new IsOpenService();
            IsOpenInfo = isOpenService.GetIsOpen();
            if (IsOpenInfo.IsOpen)
            {
                Open = "Åbent";
            }
        }
    }
}