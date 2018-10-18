using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Kocka kocka1 = new Kocka();
            Console.WriteLine(kocka1);
            for (int i = 0; i < 10; i++)
                Console.Write(kocka1.Hod() + " ");
            Console.WriteLine();
            Kocka kocka2 = new Kocka(10);
            Console.WriteLine(kocka2);
            for (int i = 0; i < 10; i++)
                Console.Write(kocka2.Hod() + " ");
            Console.ReadKey();

        }
    }
}
