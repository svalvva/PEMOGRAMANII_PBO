using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic; // Diperlukan untuk List
using System.Globalization;     // Untuk format mata uang (Rp)

namespace P4_2_714240058
{
    class Program
    {
        // Daftar untuk menyimpan semua pesanan yang dibuat selama sesi
        static List<RideService> rideHistory = new List<RideService>();

        static void Main(string[] args)
        {
            // Mengatur format budaya ke Indonesia untuk menampilkan mata uang (Rp)
            CultureInfo.CurrentCulture = new CultureInfo("id-ID", false);

            Console.WriteLine("===== Sistem Pemesanan Transportasi Online =====");
            Console.WriteLine();

            bool isRunning = true;
            while (isRunning)
            {
                // 1. Meminta Jenis Layanan
                Console.WriteLine("--- Buat Pesanan Baru ---");
                Console.WriteLine("Silakan pilih layanan:");
                Console.WriteLine("  1. Bike");
                Console.WriteLine("  2. Car");
                Console.WriteLine("  3. Premium Car");
                Console.Write("Pilihan Anda (1-3): ");
                string choice = Console.ReadLine();

                // 2. Meminta Data Umum
                Console.Write("Masukkan Nama Driver: ");
                string driver = Console.ReadLine();

                Console.Write("Masukkan Jarak (km): ");
                double distance;
                // Validasi input sederhana agar program tidak error jika input bukan angka
                while (!double.TryParse(Console.ReadLine(), out distance) || distance <= 0)
                {
                    Console.WriteLine("Input tidak valid. Masukkan angka positif untuk jarak (misal: 8.5):");
                }

                // 3. Membuat Objek (Polymorphism)
                // Kita deklarasikan variabel 'newRide' sebagai tipe abstract 'RideService'.
                RideService newRide = null;

                // 'switch' ini secara dinamis menentukan kelas mana yang akan dibuat
                // berdasarkan input pengguna.
                switch (choice)
                {
                    case "1":
                        newRide = new BikeRide(driver, distance);
                        break;
                    case "2":
                        newRide = new CarRide(driver, distance);
                        break;
                    case "3":
                        newRide = new PremiumRide(driver, distance);
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid, pesanan dibatalkan.");
                        break;
                }

                // 4. Memproses dan Menampilkan Hasil
                // Jika newRide berhasil dibuat (bukan null)
                if (newRide != null)
                {
                    // Tambahkan ke riwayat
                    rideHistory.Add(newRide);

                    Console.WriteLine("\n=== Pesanan Berhasil Dibuat! ===");
                    // Panggil helper method untuk menampilkan detail
                    DisplayRideDetails(newRide);
                }

                // 5. Pilihan untuk Mengulang atau Keluar
                Console.Write("\nBuat pesanan lain? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                {
                    isRunning = false; // Keluar dari loop while
                }
                Console.WriteLine(); // Beri spasi untuk pesanan berikutnya
            }

            // 6. Menampilkan Semua Riwayat Pesanan Sesi Ini
            Console.WriteLine("===== Riwayat Total Pesanan Sesi Ini =====");
            if (rideHistory.Count == 0)
            {
                Console.WriteLine("Tidak ada pesanan yang dibuat di sesi ini.");
            }
            else
            {
                // Loop melalui daftar dan panggil 'DisplayRideDetails' untuk setiap item.
                // Ini adalah demonstrasi polymorphism yang kuat!
                foreach (var ride in rideHistory)
                {
                    DisplayRideDetails(ride);
                }
            }

            Console.WriteLine("Terima kasih telah menggunakan sistem kami. Tekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }

        // Helper method untuk menampilkan detail layanan.
        // Metode ini menerima 'RideService' sebagai parameter,
        // dan secara otomatis akan memanggil metode override
        // (CalculateFare, etc.) yang benar berkat Polymorphism.
        public static void DisplayRideDetails(RideService ride)
        {
            Console.WriteLine("--- Detail Pesanan ---");

            // Memanggil metode GetServiceInfo() yang sudah di-override
            Console.WriteLine(ride.GetServiceInfo());

            // Memanggil metode EstimateTime() yang sudah di-override
            // :F1 memformat angka menjadi 1 desimal
            Console.WriteLine($"Estimasi Waktu: {ride.EstimateTime():F1} menit");

            // Memanggil metode CalculateFare() yang sudah di-override
            // :C memformat angka menjadi mata uang (Rupiah)
            Console.WriteLine($"Total Tarif: {ride.CalculateFare():C}");

            Console.WriteLine("----------------------");
            Console.WriteLine();
        }
    }
}

