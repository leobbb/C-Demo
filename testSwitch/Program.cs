using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input time:");
            int hour = int.Parse(Console.ReadLine());
            switch (hour)
            {
                case 6:
                    Console.WriteLine("good morning.");
                    break;
                case 7:
                    Console.WriteLine("Good morning.");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Good morning.");
                    break;
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Good noon.");
                    break;
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    Console.WriteLine("Good afternoon.");
                    break;
                default :
                    Console.WriteLine("Have a rest.");
                    break;


                
            }
            Console.ReadLine();
        }
    }
}
