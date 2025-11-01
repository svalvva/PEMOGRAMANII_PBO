using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ulangi = true;

            // Menggunakan loop do-while agar program berjalan setidaknya satu kali
            // dan terus mengulang selama 'ulangi' bernilai true
            do
            {
                // Membersihkan konsol setiap kali menu utama ditampilkan
                Console.Clear();
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                // Membaca input menu dari user
                // Asumsi input selalu berupa angka (sesuai contoh praktikum)
                int menu = Convert.ToInt32(Console.ReadLine());

                // Struktur switch untuk menangani pilihan menu
                switch (menu)
                {
                    case 1:
                        // --- HITUNG LUAS ---
                        Console.Write("Masukkan panjang: ");
                        int panjangL = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        int lebarL = Convert.ToInt32(Console.ReadLine());

                        int luas = panjangL * lebarL; // Rumus Luas

                        Console.WriteLine($"Luas Persegi Panjang: {luas}");
                        break;

                    case 2:
                        // --- HITUNG KELILING ---
                        Console.Write("Masukkan panjang: ");
                        int panjangK = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        int lebarK = Convert.ToInt32(Console.ReadLine());

                        int keliling = 2 * (panjangK + lebarK); // Rumus Keliling

                        Console.WriteLine($"Keliling Persegi Panjang: {keliling}");
                        break;

                    case 3:
                        // --- KELUAR ---
                        Console.WriteLine("Program selesai.");
                        ulangi = false; // Set flag 'ulangi' ke false untuk menghentikan loop
                        break;

                    default:
                        // --- INPUT MENU TIDAK VALID ---
                        Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                        break;
                }

                // Bagian ini dieksekusi setelah switch, TAPI hanya jika user tidak memilih '3'
                if (ulangi) // atau bisa juga ditulis 'if (menu != 3)'
                {
                    Console.Write("Ingin mengulang kembali (Y/T)? ");
                    string jawaban = Console.ReadLine();

                    // Jika user input 'T' atau 't', set flag 'ulangi' ke false
                    if (jawaban.ToUpper() == "T")
                    {
                        ulangi = false;
                    }
                    // Jika user input 'Y' atau lainnya, 'ulangi' tetap true dan loop akan berlanjut
                }

            } while (ulangi); // Loop akan terus berjalan selama 'ulangi' adalah true

            // Pesan ini ditampilkan setelah loop 'do-while' berakhir
            Console.WriteLine("Terima kasih!");

            // Menambahkan ini untuk meniru output "Press any key to continue"
            // yang terlihat di screenshot PDF
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
