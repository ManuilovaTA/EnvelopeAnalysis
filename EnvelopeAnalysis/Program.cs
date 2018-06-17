using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeAnalysis
{
    class Program
    {

        static void Main(string[] args)
        {
            string refresh;
            double a, b, c, d;
            Envelope test = new Envelope();

            do
            {
                Console.WriteLine("Введите длину сторон конверта №1:");
                Console.Write("Сторона a = ");
                a = test.Input();

                Console.Write("Сторона b = ");
                b = test.Input();

                Console.WriteLine("Введите длину сторон конверта №2:");
                Console.Write("Сторона c = ");
                c = test.Input();

                Console.Write("Сторона d = ");
                d = test.Input();

                test.AccommodateEnvelopes(a, b, c, d);

                Console.WriteLine("Продолжить выполнение программы? Введите “y” или “yes”");
                refresh = Console.ReadLine().ToUpper();

            }
            while (refresh == "Y" || refresh == "YES");

            Console.ReadKey();

        }
    }
}
