using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama  \t: Anis Kurnia Rahmawati");
            Console.WriteLine("NIM   \t: 19.11.2664");
            Console.WriteLine("Kelas \t: Informatika 02\n");

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Espon");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1-3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            IPrinterWindows printer;

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
