using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //            Console.WriteLine(myValue.ToString());
            //            Console.WriteLine(myValue.ToShortDateString());
            //            Console.WriteLine(myValue.ToShortTimeString());
            //            Console.WriteLine(myValue.ToLongTimeString());
            //            Console.WriteLine(myValue.ToLongDateString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); 
            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1522, 2, 4);
            //Console.WriteLine(myBirthday.ToLongDateString());


            DateTime myBirthday = DateTime.Parse("12/07/1888");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalSeconds);

            Console.ReadLine();
        }
    }
}
