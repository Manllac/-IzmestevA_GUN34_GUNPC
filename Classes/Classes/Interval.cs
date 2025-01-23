using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Interval
    {
     
            private static Random random = new Random();

            public int Min { get; private set; }
            public int Max { get; private set; }

            public double Get
            {
                get
                {

                    return random.Next(Min, Max + 1);

                }
            }

            public Interval(int minValue, int maxValue)
            {
                if (minValue > maxValue)
                {
                    (minValue, maxValue) = (maxValue, minValue);
                    Console.WriteLine("Некорректные входные данные");
                }
                if (minValue < 0)
                {
                    minValue = 0;
                    Console.WriteLine("Минимальные значение меньше 0");
                }

                if (maxValue < 0)
                {
                    maxValue = 0;
                    Console.WriteLine("Максимальные значения иеньше 0");
                }

                if (minValue == maxValue)
                {
                    maxValue += 10;
                    Console.WriteLine("Значения min и max равны");
                }

                Min = minValue;
                Max = maxValue;
            }


        }
    }

