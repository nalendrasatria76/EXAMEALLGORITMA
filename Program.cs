using System;
using System.Security.Cryptography.X509Certificates;

namespace Bubble_Short
{
    class program
    {
        // Deklarasi Array Int Dengan Ukuran 20
        private int[] a = new int[20];

        //Deklarasi Variabel Int Untuk Menyimoan Banyaknya Data Pada Array
        private int n;

        //Fungsi / Method Untuk Menerima Masukan
        public void read()
        {
            //Menerima Angka Untuk Menentukan Banyaknya Data Yang Disimpan Pada Array
            while (true)
            {
                Console.Write("Masukkan Banyaknya Elemen Pada Array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray Dapat Mempunyai Maksimal 20 Elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan Elemen Array ");
            Console.WriteLine("-----------------------");

            // Pengguna Memasukkan Elemen Pada Array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan Array Yang Tersusun
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Elemen Array Yang Telah Tersusun");
            Console.WriteLine("--------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) //For n - 1 passes
            {
                // Pada pass i, Bandingkan n - i Elemen Pertama Dengan Elemen Selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // Jika Elemen Tidak Dalam Urutan Yang Benar
                    {
                        // Tukar Elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating The Object Of The BubbleSort Class
            program mylist = new program();

            // Pemanggilan Fungsi Untuk Menerima Elemen Array
            mylist.read();
            // Pemanggilan Fungsi Untuk Mengurutkan Array
            mylist.BubbleSortArray();
            //Pemanggilan Fungsi Untuk Menampilkan Array Yang Tersusun
            mylist.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}