using Fawry_Internship.Enums;
using Fawry_Internship.Rules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Internship.Models
{
    public class Observation
    {
        public Observation(string plateNumber, DateTime date, CarType carType, int speed, bool seatbeltStatus)
        {
            PlateNumber = plateNumber;
            Date = date;
            CarType = carType;
            Speed = speed;
            SeatbeltStatus = seatbeltStatus;
        }

      

        public string PlateNumber  { get; set; }

        public DateTime Date { get; set; }

        public CarType CarType { get; set; }

        public int Speed { get; set; }

        public bool SeatbeltStatus  { get; set; }


     
        

        


    }
}
