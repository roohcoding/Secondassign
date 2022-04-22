using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoinAssignment
{
    internal class LeapYear
    {
        public static int Year;
        public static void Leapyear()
        {
                int year;
                Console.WriteLine("Enter Year");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(year % 4 == 0 ? "Entered year is a leap" : "Not leap year");
                Console.ReadLine();

                Console.ReadLine();
        }
 
        
        
    }
}
