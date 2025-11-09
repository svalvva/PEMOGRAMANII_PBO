using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240058
{
    // INHERITANCE:
    public class CarRide : RideService
    {
        // CONSTRUCTOR:
        public CarRide(string driverName, double distance)
            : base(driverName, distance)
        {
            RideType = "Car";
            BaseFare = 10000; // Tarif dasar mobil
        }

        // POLYMORPHISM:
        // Implementasi tarif untuk mobil berbeda.
        public override double CalculateFare()
        {
            // Tarif = Tarif Dasar + (Jarak * 4000)
            return BaseFare + (Distance * 4000);
        }

        // POLYMORPHISM:
        // Estimasi waktu dengan kecepatan rata-rata mobil (misal: 40 km/jam).
        public override double EstimateTime()
        {
            double averageSpeedKmh = 40.0;
            return (Distance / averageSpeedKmh) * 60;
        }

        // POLYMORPHISM:
        // Meng-override metode abstract GetServiceInfo().
        public override string GetServiceInfo()
        {
            return $"Layanan: {RideType}, Driver: {DriverName}, Jarak: {Distance:F1} km";
        }
    }
}
