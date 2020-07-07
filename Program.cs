using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectKostumer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek Kostumer
        static List<Kostumer> daftarKostumer = new List<Kostumer>();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                switch (nomorMenu)
                {
                    case 1:
                        TambahKostumer();
                        break;

                    case 2:
                        HapusKostumer();
                        break;

                    case 3:
                        TampilKostumer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Costumer");
            Console.WriteLine("2. Hapus Costumer");
            Console.WriteLine("3. Tampilkan Costumer");
            Console.WriteLine("4. Keluar");
        }
        static void TambahKostumer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan Kostumer ke dalam collection
            Console.WriteLine();
            Console.WriteLine("Tambah Data Kostumer\n");
            Kostumer Kostumer = new Kostumer();
            Console.Write("Kode Kostumer : ");
            Kostumer.KodeKost = Console.ReadLine();
            Console.Write("Nama Kostumer : ");
            Kostumer.NamaKost = Console.ReadLine();
            Console.Write("Total Piutang  : ");
            Kostumer.TotalUtang = Convert.ToDouble(Console.ReadLine());
            daftarKostumer.Add(Kostumer);
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusKostumer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menghapus Kostumer dari dalam collection
            int i = -1, hapus = -1;
            Console.WriteLine("Hapus Data Kostumer\n");
            Console.Write("Kode Kostumer : ");
            string kode = Console.ReadLine();
            foreach (Kostumer Kostumer in daftarKostumer)
            {
                i++;
                if (Kostumer.KodeKost == kode)
                {
                    hapus = i;
                }
            }
            if (hapus != -1)
            {
                daftarKostumer.RemoveAt(hapus);
                Console.WriteLine("\nData Kostumer Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Kostumer tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilKostumer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar Kostumer yang ada di dalam collection
            int Urut = 0;
            Console.WriteLine("Data Kostumer\n");
            foreach (Kostumer Kostumer in daftarKostumer)
            {
                Urut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0}", Urut, Kostumer.KodeKost, Kostumer.NamaKost, Kostumer.TotalUtang);
            }
            if (Urut < 1)
            {
                Console.WriteLine("Data Kostumer Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
