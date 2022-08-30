using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Travel_Record_App.Helpers;

namespace Travel_Record_App.Model
{
    public class Venue
    {
        public static string GenerateURL(double latitude, double longitude)
        {
           return string.Format(Constants.VENUE_SEARCH, latitude, longitude, Constants.CLIENT_ID, Constants.CLIENT_SECRET, DateTime.Now.ToString("yyyyMMdd"));
        }
    }
}
