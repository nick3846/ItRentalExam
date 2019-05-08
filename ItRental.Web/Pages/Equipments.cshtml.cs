using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ItRental.Dal;
using ItRental.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItRental.Web.Pages
{
    public class EquipmentsModel : PageModel
    {
        [BindProperty]
        public Equipment Equipment { get; set; }
        public List<Equipment> Equipments { get; set; } = new List<Equipment>();
        EquipmentRepository EquipmentRepository { get; set; } = new EquipmentRepository();

        public EquipmentsModel()
        {
            Equipments = EquipmentRepository.GetEquipments();
        }
        public void OnGet()
        {
            
        }
        public void OnPostInsert()
        {
            EquipmentRepository.Insert(Equipment);
            Equipments.Add(Equipment);
        }
    }
}