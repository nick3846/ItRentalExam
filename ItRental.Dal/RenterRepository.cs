using ItRental.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ItRental.Dal
{
    public class RenterRepository : BaseRepository
    {
        public List<Renter> GetRenters()
        {
            return HandleData(ExecuteQuery("SELECT * FROM Renter"));
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
                    RenterLevel = (RenterLevel)row["RenterLevel"],
                };

                renters.Add(renter);
            }
            return renters;
        }
    }
}
