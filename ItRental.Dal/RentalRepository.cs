using ItRental.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ItRental.Dal
{
    public class RentalRepository : BaseRepository
    {
        public List<Rental> GetRentals()
        {
            return HandleData(ExecuteQuery("SELECT * FROM Rentals"));
        }

        public int Insert(Rental rental)
        {
            return ExecuteNonQuery($"INSERT INTO Rentals VALUES('{DateTime.Now.ToString("yyyy-MM-dd")}', '{rental.ReturnTime.ToString("yyyy-MM-dd")}', '{rental.Equipment.Id}', '{rental.Units}', '{rental.Renter.Id}')");
        }

        private List<Rental> HandleData(DataTable dataTable)
        {
            EquipmentRepository equipmentRepository = new EquipmentRepository();
            RenterRepository renterRepository = new RenterRepository();

            List<Rental> rentals = new List<Rental>();
            if (dataTable is null)
                return rentals;
            foreach (DataRow row in dataTable.Rows)
            {
                Rental rental = new Rental()
                {
                    Id = (int)row["RentalId"],
                    RentalTime = (DateTime)row["RentalTime"],
                    ReturnTime = (DateTime)row["ReturnTime"],
                    Equipment = equipmentRepository.GetById((int)row["EquipmentId"]),
                    Units = (int)row["Units"],
                    Renter = renterRepository.GetById((int)row["RenterId"])
                };
                rentals.Add(rental);
            }
            return rentals;
        }

        public List<Rental> GetByRenterId(int id)
        {
            return HandleData(ExecuteQuery($"SELECT * FROM Rentals WHERE RenterId = {id}"));
        }
    }
}
