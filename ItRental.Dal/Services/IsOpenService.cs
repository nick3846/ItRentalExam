using ItRental.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ItRental.Dal.Services
{
    public class IsOpenService
    {
        private string Url { get; set; } = "http://api.aspitcloud.dk/isopen";
        public IsOpenInfo GetIsOpen()
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                using (var client = new WebClient())
                {
                    string json = client.DownloadString(Url);
                    IsOpenInfo isOpenInfo= JsonConvert.DeserializeObject<IsOpenInfo>(json);
                    return isOpenInfo;
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}

