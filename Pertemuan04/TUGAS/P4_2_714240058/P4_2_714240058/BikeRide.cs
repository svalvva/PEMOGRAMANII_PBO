using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240058
{
    // INHERITANCE
    public class BikeRide : RideService
    {
        // CONSTRUCTOR:
        // Meneruskan parameter ke 'base' constructor (RideService)
        public BikeRide(string driverName, double distance)
            : base(driverName, distance)
        {
            // Mengatur properti spesifik untuk kelas ini
            RideType = "Bike";
            BaseFare = 5000; // Tarif dasar motor
        }

        // POLYMORPHISM:
        public override double CalculateFare()
        {
            // Tarif = Tarif Dasar + (Jarak * 2000)
            return BaseFare + (Distance * 2000);
        }

        // POLYMORPHISM:
        public override double EstimateTime()
        {
            double averageSpeedKmh = 35.0;
            // Waktu (menit) = (Jarak / Kecepatan) * 60
            return (Distance / averageSpeedKmh) * 60;
        }

        // POLYMORPHISM:
        public override string GetServiceInfo()
        {
            return $"Layanan: {RideType}, Driver: {DriverName}, Jarak: {Distance:F1} km";
        }
    }
}
