using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello.Net");
           // Console.Read();
            double ticket = 4000;
            double result = 0.0;
            
            int month = DateTime.Now.Month;
            Console.WriteLine("time : {0} month", month);
            Console.WriteLine("input type of ticket:1. top ticket; 2. low ticket");
            int type = int.Parse(Console.ReadLine());
            if (month >= 5 && month <= 10)
            {
                if (type == 1)
                    result = ticket * 0.9;
                else if (type == 2)
                    result = ticket * 0.75;
            }
            else
            {
                if (type == 1)
                    result = ticket * 0.6;
                else if (type == 2)
                    result = ticket * 0.3;

            }
            Console.WriteLine("you need pay ${0} for the ticket. ", result);
            Console.ReadLine();
        }
    }
}
