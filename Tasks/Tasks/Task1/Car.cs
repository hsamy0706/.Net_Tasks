using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task1
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Age { get { return DateTime.Now.Year - Year; } }
        public double Mileage { get; private set; }

        public void Drive(int distance)
        {
            if (distance > 0)
                Mileage += distance;
            else
                Console.WriteLine("You can't add -ve distance");

        }
    }
}
