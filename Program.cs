using System;

/* Created by Rizky Khapidsyah */

namespace PengenalanMethod__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nama, InputS;
            String[] Kalimat = new String[6];
            String[] PesanError = new string[2];

            double P, L, T;
            
            //Pustaka Kalimat
            Kalimat[0] = "-";
            Kalimat[1] = "MENGHITUNG LUAS DAN VOLUME BALOK";
            Kalimat[2] = "Silahkan Ulangi.";
            Kalimat[3] = "Kesalahan: ";
            Kalimat[4] = "\nProgram Diulang!\n\n";
            Kalimat[5] = "PENGENALAN METHOD PADA C#";
            PesanError[0] = Kalimat[3] + "Lebar Lebih Besar Dari Panjang!" + Kalimat[4];
            PesanError[1] = Kalimat[3] + "Lebar Sama Dengan Panjang!" + Kalimat[4];

            CetakJudul(Kalimat[0], Kalimat[5]);
            CetakJudul(Kalimat[0], null);
            Console.Write("Masukkan Nama Anda : "); Nama = Console.ReadLine();

            UcapkanHalo(Nama); Console.WriteLine();

            Mulai:
            CetakJudul(Kalimat[0], Kalimat[1]);
            CetakJudul(Kalimat[0], null);

            try
            {
                Console.Write("Nilai Panjang  : "); P = Convert.ToDouble(InputS = Console.ReadLine());
                Console.Write("Nilai Lebar    : "); L = Convert.ToDouble(InputS = Console.ReadLine());
                Console.Write("Nilai Tinggi   : "); T = Convert.ToDouble(InputS = Console.ReadLine());

                if (P <= L)
                {
                    Console.WriteLine("\n" + PesanError[0]);
                    goto Mulai;
                }
                else if (P == L)
                {
                    Console.WriteLine("\n" + PesanError[1]);
                    goto Mulai;
                }
                else
                {
                    Console.WriteLine("\nLuas      = {0}", HitungLuas(P, L, T));
                    Console.WriteLine("Volume    = {0}", HitungVolume(P, L, T));
                }
            } catch(Exception e)
            {
                 Console.WriteLine(e);
            }

            Console.ReadLine();
        }

        static void UcapkanHalo(string NamaParam)
        {
            Console.Write("\nHaloo.. Apa Kabar {0}!\n" +
                "Mari kita mulai menghitung!\n" +
                "Silahkan Tekan Enter!", NamaParam);
            Console.ReadLine();
        }

        static void CetakJudul(string KalimatParam1, string KalimatParam2)
        {
            for (int i = 0; i <= 40; i++)
            {
                Console.Write(KalimatParam1);
            }
            Console.WriteLine();
            Console.WriteLine(KalimatParam2);
        }

        static double HitungLuas(double Pparam, double Lparam, double Tparam)
        {
            double Hasil;
            Hasil = (2 * Pparam) + (2 * Lparam) + (2 * Tparam);
            return Hasil;
        }

        static double HitungVolume(double Pparam, double Lparam, double Tparam)
        {
            double Hasil;
            Hasil = (Pparam * Lparam * Tparam);
            return Hasil;
        }
    }
}
