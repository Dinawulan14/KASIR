using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

//namespace adalah nama project
namespace KASIR
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remaks>class KasirCafe dapat membuat operasi args</remaks>
    public class KasirCafe
    {
        /// <summary>
        /// operasi pertambahan
        /// </summary>
        /// <param name="args">angka pertama dalam operasi pertambahan</param>
        public static void Main(string[] args)
        {
            //Pembuka
            //Console WriteLine adalah menampilkan teks dalam satu baris atau baris baru
            Console.WriteLine();
            Console.WriteLine("***************************************************");
            Console.WriteLine();
            Console.WriteLine("                    SELAMAT DATANG                 ");
            Console.WriteLine();
            Console.WriteLine("         BERANEKA RAGAM RASA YANG BERKUALITAS      ");
            Console.WriteLine();
            Console.WriteLine("************************************************** ");

            //Transaksi
            //Console WriteLine adalah menampilkan teks dalam satu baris atau baris baru
            Console.WriteLine();
            Console.WriteLine("        BERIKUT MENU PILIHAN KAMI     ");
            Console.WriteLine("          MAKANAN DAN MINUMAN         ");
            Console.WriteLine("**************************************");
            Console.WriteLine("1. Nasi Goreng       = Rp 12.000");
            Console.WriteLine("2. Ayam Bakar        = Rp 13.000");
            Console.WriteLine("3. Es Jeruk          = Rp 7000");
            Console.WriteLine("4. Es Cofee          = Rp 5000");

            //Deklarasi variabel
            //String adalah fungsi karakter yang digunakan mengoperasikan data
            string pilihan, namapl;
            byte quantity = 0;
            //uint adalah type data yg sama dengan integer, namun hanya berisi bilangan positif
            uint nasiGoreng = 12000, ayambakar = 13000;
            uint escofee = 5000, esjeruk = 7000;
            uint totalHarga, tunai, kembalian = 0;

            Console.WriteLine();
            //Console Write yaitu tidak akan membuat baris baru
            Console.Write("Masukkan Pesanan Yang Dipilih = ");
            pilihan = Convert.ToString(Console.ReadLine());

            //1. input Nasi Goreng 12000

            if (pilihan == "1")
            {
                Console.WriteLine();
                Console.WriteLine("  1. Nasi Goreng ");
                Console.WriteLine("                 ");

                //2. input quantity

                Console.WriteLine();
                Console.Write("Masukkan Quantity = ");
                quantity = Convert.ToByte(Console.ReadLine());

                //3. Proses total Harga
                totalHarga = nasiGoreng * quantity;

                //4. Output total harga
                Console.WriteLine();
                Console.WriteLine("*************************************");
                Console.WriteLine("      Total Harga : Rp{0}", totalHarga.ToString());

                //5. input Tunai
                Console.Write("  Tunai = Rp");
                tunai = Convert.ToUInt32(Console.ReadLine());

                //6. Proses kembalian
                kembalian = tunai - totalHarga;

                //7. Output Kembalian

                Console.WriteLine("   Kembalian : Rp{0}", kembalian.ToString());
                Console.WriteLine("*****************************************");

                //8. output nama pembeli

                Console.Write("     Nama Pembeli : = ");
                namapl = Convert.ToString(Console.ReadLine());

                //9. menampilkan tanggal dan waktu membeli
                Console.WriteLine("Tanggal Transaksi:" + DateTime.Today.ToString("yyyy-mm-yy"));
                Console.WriteLine("Jam Membeli :" + DateTime.Now.ToString("yyyy-mm-dd"));
                Console.WriteLine("\n");

                //10. menampilkan nama kasir
                Console.WriteLine();
                Console.WriteLine("Nama Kasir = Dina Wulan ");
                Console.WriteLine("Terima kasih Sudah Memesan");
                Console.WriteLine("\n");
            }

            //1. input Ayam Bakar 13000

            if (pilihan == "2")
            {
                Console.WriteLine();
                Console.WriteLine("    2. Ayam Bakar   ");
                Console.WriteLine("**********************");

                //2. input quantity

                Console.WriteLine();
                Console.Write("Maskkkan Quantity = ");
                quantity = Convert.ToByte(Console.ReadLine());

                //3. proses total harga

                totalHarga = ayambakar * quantity;

                //4. output total harga

                Console.WriteLine();
                Console.WriteLine("*************************");
                Console.WriteLine("    TotalHarga : Rp{0}", totalHarga.ToString());

                //5. input Tunai

                Console.Write("    Tunai : Rp");
                tunai = Convert.ToUInt32(Console.ReadLine());

                //6. Proses pengembalian

                kembalian = tunai - totalHarga;

                //7. Output kembalian

                Console.WriteLine("     Kembalian :Rp{0}", kembalian.ToString());
                Console.WriteLine("********************************************");

                //8. output nama pembeli

                Console.Write("     Nama Pembeli : = ");
                namapl = Convert.ToString(Console.ReadLine());

                //9. menampilkan tanggal dan waktu membeli
                Console.WriteLine("Tanggal Transaksi:" + DateTime.Today.ToString("yyyy-mm-yy"));
                Console.WriteLine("Jam Membeli :" + DateTime.Now.ToString("yyyy-mm-dd"));
                Console.WriteLine("\n");

                //10. menampilkan nama kasir
                Console.WriteLine();
                Console.WriteLine("Nama Kasir = Dina Wulan ");
                Console.WriteLine("Terima kasih Sudah Memesan");
                Console.WriteLine("\n");
            }

            //1. input Es Jeruk 7000

            if (pilihan == "3")
            {
                Console.WriteLine();
                Console.WriteLine("   3. Es Jeruk 7000");
                Console.WriteLine("********************");

                //2. input quantity

                Console.WriteLine();
                Console.WriteLine("Masukkan Quantity = ");
                quantity = Convert.ToByte(Console.ReadLine());

                //3. Proses total harga

                totalHarga = esjeruk * quantity;

                //4. Output total harga

                Console.WriteLine();
                Console.WriteLine("*******************************");
                Console.WriteLine("    Total Harga : Rp{0}", totalHarga.ToString());

                //5. Input Tunai

                Console.Write("    Tunai : Rp");
                tunai = Convert.ToUInt32(Console.ReadLine());

                //6. Proses kembalian

                kembalian = tunai - totalHarga;

                //7. Output kembalian

                Console.WriteLine("   Kembalian : Rp{0}", kembalian.ToString());
                Console.WriteLine("*******************************************");

                //8. output nama pembeli

                Console.Write("     Nama Pembeli : = ");
                namapl = Convert.ToString(Console.ReadLine());

                //9. menampilkan tanggal dan waktu membeli
                Console.WriteLine("Tanggal Transaksi:" + DateTime.Today.ToString("yyyy-mm-yy"));
                Console.WriteLine("Jam Membeli :" + DateTime.Now.ToString("yyyy-mm-dd"));
                Console.WriteLine("\n");

                //10. menampilkan nama kasir
                Console.WriteLine();
                Console.WriteLine("Nama Kasir = Dina Wulan ");
                Console.WriteLine("Terima kasih Sudah Memesan");
                Console.WriteLine("\n");
            }

            //1. input Cofee 5000

            if (pilihan == "4")
            {
                Console.WriteLine();
                Console.WriteLine("    4. Es Cofee 5000 ");
                Console.WriteLine("*************************");

                //2. input quantity

                Console.WriteLine();
                //Display 'Masukkan Quantitasnya: '
                Console.Write("Masukkan Quantity :");
                //Convert toByte adalah mengganti suatu type data menjadi type data Byte
                quantity = Convert.ToByte(Console.ReadLine());

                //3. proses total harga

                totalHarga = escofee * quantity;

                //4. output total harga

                Console.WriteLine();
                Console.WriteLine("****************************************");
                Console.WriteLine("    Total harga : Rp{0}", totalHarga.ToString());

                //5. input Tunai
                //Display 'Masukkan Tunai Pembayaran: '
                Console.Write("      Tunai  :Rp");
                //Convert ToInt32 mengganti suatu type data menjadi type data integer
                tunai = Convert.ToUInt32(Console.ReadLine());

                //6. Proses kembalian

                kembalian = tunai - totalHarga;

                //7. Output kembalian 

                Console.WriteLine("    kembalian : Rp{0}", kembalian.ToString());
                Console.WriteLine("********************************************");

                //8. output nama pembeli

                Console.Write("     Nama Pembeli : = ");
                //Convert ToString adalah mengganti suatu type data menjadi type data string
                namapl = Convert.ToString(Console.ReadLine());

                //9. menampilkan tanggal dan waktu membeli
                Console.WriteLine("Tanggal Transaksi:" + DateTime.Today.ToString("yyyy-mm-yy"));
                Console.WriteLine("Jam Membeli :" + DateTime.Now.ToString("yyyy-mm-dd"));
                Console.WriteLine("\n");

                //10. menampilkan nama kasir
                Console.WriteLine();
                Console.WriteLine("Nama Kasir = Dina Wulan ");
                Console.WriteLine("Terima kasih Sudah Memesan");
                Console.WriteLine("\n");
            }

            //Penutup
            //Console WriteLine adalah menampilkan teks dalam satu baris atau baris baru
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
            Console.WriteLine("****************TERIMA KASIH SUDAH MELAKUKAN TRANSAKSI********************");
            Console.WriteLine();
            Console.WriteLine("***************TERIMA KASIH SUDAH MEMPERCAYAI CAFE KAMI*******************");
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");

            Console.WriteLine();

            // Mengulang Transakasi 
            Console.WriteLine();
            Console.Write("Apakah Anda akan kembali ke Menu Utama? [Y/N = ");
            Console.WriteLine("1. Y");
            Console.WriteLine("2. N");
            //Console Readline berfungsi untuk membaca inputan serta menahan jalannya program hingga user menekan tombol Enter
            Console.ReadLine();

            Console.WriteLine(" Tekan Enter Untuk Melanjutkan ");
            Console.Write("Enter");
            //Console.ReadKey bertujuan menunggu karakter yang diinputkan dengan tujuan agar program saat di run tidak langsung keluar
            Console.ReadKey(true);
        }
    }
}