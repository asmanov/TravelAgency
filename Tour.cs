using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class Tour
    {
        public Tour(string hotel, int stars, string destination, string whereFrom, double cost, int amountOfDay, DateTime date)
        {
            Hotel = hotel ?? throw new ArgumentNullException(nameof(hotel));
            Stars = stars;
            Destination = destination ?? throw new ArgumentNullException(nameof(destination));
            WhereFrom = whereFrom ?? throw new ArgumentNullException(nameof(whereFrom));
            Cost = cost;
            AmountOfDay = amountOfDay;
            DateStart = date;
        }

        public string Hotel { get; set; }
        public int Stars { get; set; }
        public string Destination { get; set; }
        public string WhereFrom { get; set; }
        public double Cost { get; set; }
        public int AmountOfDay { get; set; }
        DateTime DateStart { get; set; }

    }
}
