using ItRental.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ItRental.Dal.Services
{
    public class OpeningHoursService
    {
        private string Url { get; set; } = "http://api.aspitcloud.dk/openinghours";
        public OpeningHoursInfo GetOpeningHours()
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                using (var client = new WebClient())
                {
                    string json = client.DownloadString(Url);
                    OpeningHoursInfo openingHoursInfo = JsonConvert.DeserializeObject<OpeningHoursInfo>(json);
                    return openingHoursInfo;
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
