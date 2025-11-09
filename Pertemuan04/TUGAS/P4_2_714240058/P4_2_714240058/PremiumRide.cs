using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240058
{
    // INHERITANCE:
    public class PremiumRide : RideService
    {
        // CONSTRUCTOR:
        public PremiumRide(string driverName, double distance)
            : base(driverName, distance)
        {
            RideType = "Premium Car";
            BaseFare = 20000; // Tarif dasar premium
        }

        // POLYMORPHISM:
        // Implementasi tarif untuk mobil premium berbeda.
        public override double CalculateFare()
        {
            // Tarif = Tarif Dasar + (Jarak * 8000)
            return BaseFare + (Distance * 8000);
        }

        // POLYMORPHISM:
        // Estimasi waktu dengan kecepatan rata-rata mobil premium (misal: 50 km/jam).
        public override double EstimateTime()
        {
            double averageSpeedKmh = 50.0;
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
