using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeAnalysis
{
    public class Envelope
    {
        public double a;
        public double Input()
        {
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка. Вы ввели не число \n Введите повторно:");
                Input();
            }
            if (a <= 0)
            {
                Console.WriteLine("Ошибка. Вы ввели отрицатльное число \n Введите повторно:");
                Input();
            }
               
            return a;
        }

        public void AccommodateEnvelopes(double a, double b, double c, double d)
        {
            if ((a < c && b < d) || (a < d && b < c))
            {
                Console.WriteLine("Конверт №1 можно вложить в конверт №2");
            }
            else if ((c < a && d < b) || (c < b && d < a))
            {
                Console.WriteLine("Конверт №2 можно вложить в конверт №1");
            }
            else if (c >= d && a >= b && DiagonalFit(a, b, c, d))
            {
                Console.WriteLine("Конверт №2 можно вложить в конверт №1");
            }
            else if(d >= c && b >= a && DiagonalFit(a, b, d, c))
            {
                Console.WriteLine("Конверт №2 можно вложить в конверт №1");
            }
            else if(c >= d && a >= b && DiagonalFit(c, d, a, b))
            {
                Console.WriteLine("Конверт №1 можно вложить в конверт №2");
            }
            else if (d >= c && b >= a && DiagonalFit(c, d, b, a))
            {
                Console.WriteLine("Конверт №1 можно вложить в конверт №2");
            }
            else
            {
                Console.WriteLine("Конверты нельзя вложить друг в друга");
            }

        }

        public bool DiagonalFit(double bSbT, double sSbT, double bSsT, double sSsT)
        {
            double aPow = Math.Pow(bSbT, 2);
            double bPow = Math.Pow(sSbT, 2);
            double cPow = Math.Pow(bSsT, 2);
            double dPow = Math.Pow(sSsT, 2);
            
            if ((bSsT <= bSbT && sSsT <= sSbT) || ((bSsT > a) && sSbT >= (2 * bSsT * sSsT * bSbT + (cPow + dPow) * Math.Sqrt(cPow + dPow - aPow)) / (cPow + dPow)))
            {
                return true;
            }
            else return false;
           }
        }
    }

