using System;

namespace Aula93
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);

            // Calculate the interval between the two dates.
            TimeSpan interval = date2 - date1;
            Console.WriteLine("{0} - {1} = {2}", date2, date1, interval.ToString());

            Console.WriteLine();

            Console.WriteLine("d1: "+d1);
            Console.WriteLine("d1.Kind: "+d1.Kind);
            Console.WriteLine("d1.Local: "+d1.ToLocalTime() );
            Console.WriteLine("d1.Utc: "+d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2.Kind: " + d2.Kind);
            Console.WriteLine("d2.Local: " + d2.ToLocalTime());
            Console.WriteLine("d2.Utc: " + d2.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3.Kind: " + d3.Kind);
            Console.WriteLine("d3.Local: " + d3.ToLocalTime());
            Console.WriteLine("d3.Utc: " + d3.ToUniversalTime());

        }
    }
}
