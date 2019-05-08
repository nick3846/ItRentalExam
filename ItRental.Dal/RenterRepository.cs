using ItRental.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ItRental.Dal
{
    public class RenterRepository : BaseRepository
    {
        public List<Renter> GetRenters()
        {
            return HandleData(ExecuteQuery("SELECT * FROM Renters"));
        }

        public int Insert(Renter renter)
        {
            return ExecuteNonQuery($"INSERT INTO Renters VALUES('{renter.Name}', {(int)renter.RenterLevel})");
        }

        private List<Renter> HandleData(DataTable dataTable)
        {
            List<Renter> renters = new List<Renter>();
            if (dataTable is null)
                return renters;

            foreach (DataRow row in dataTable.Rows)
            {
                Renter renter = new Renter()
                {
                    Id = (int)row["RenterId"],
                    Name = (string)row["Name"],
                    RenterLevel = (RenterLevel)row["RenterLevel"]
                };

                renters.Add(renter);
            }
            return renters;
        }
        public Renter GetById(int id)
        {
            DataTable renterTable = ExecuteQuery($"SELECT * FROM Renters WHERE RenterId = {id}");
            return HandleData(renterTable).FirstOrDefault();
        }
    }
}
