using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var schoolStartDateTime = new System.DateTime(2020,1,18);
            var now = System.DateTime.Now;
            var today = System.DateTime.Today;
            Console.WriteLine(now);
            Console.WriteLine(today);
            Console.WriteLine(schoolStartDateTime);

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Day: " + now.Day);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(tomorrow + " " + yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            //both date and time.
            Console.WriteLine(now.ToString("yy-MMM-dd ddd"));
        }
    }
}
