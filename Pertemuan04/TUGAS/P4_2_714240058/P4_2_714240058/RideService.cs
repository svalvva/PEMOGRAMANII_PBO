using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240058
{
    public abstract class RideService
    {
        // ENCAPSULATION (Fields & Properties
        public string DriverName { get; set; }
        public double Distance { get; set; }
        public string RideType { get; protected set; } // Hanya bisa di-set oleh child class
        protected double BaseFare { get; set; } // Hanya bisa diakses oleh child class

        // CONSTRUCTOR:
        public RideService(string driverName, double distance)
        {
            DriverName = driverName;
            Distance = distance;
        }

        // ABSTRACT METHODS (Abstraction):

        public abstract double CalculateFare();
        public abstract double EstimateTime();
        public abstract string GetServiceInfo();
    }
}
