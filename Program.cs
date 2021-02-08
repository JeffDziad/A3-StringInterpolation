using System;

namespace A3_StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            double pie = Math.PI;

            Console.WriteLine("0----|----|----|----|----|----|----|----40");

            //January 22, 2019
            Console.WriteLine(today.ToString("MMMM d, yyyy"));

            //2019.01.22
            Console.WriteLine(today.ToString("yyyy.MM.dd"));

            //Day 22 of January, 2019
            Console.WriteLine($"Day {today.ToString("dd")} of {today.ToString("MMMM")}, {today.ToString("yyyy")}");

            //Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"Year: {today.ToString("yyyy")}, Month: {today.ToString("MM")}, Day: {today.ToString("dd")}");

            //            Tuesday (10 spaces)
            Console.WriteLine(String.Format("{0, 10}", today.ToString("dddd")));

            //     11:01 PM             Tuesday (10 spaces between)
            Console.WriteLine(String.Format("{0, 10} {1, 20}", today.ToString("h:mm tt"), today.ToString("dddd")));

            //h:11, m:01, s:27
            Console.WriteLine("h:{0}, m:{1}, s:{2}", today.ToString("hh"), today.ToString("mm"), today.ToString("ss"));

            //2019.01.22.11.01.2
            Console.WriteLine($"{today.ToString("yyyy")}.{today.ToString("MM")}.{today.ToString("dd")}.{today.ToString("hh")}.{today.ToString("mm")}.{today.ToString("ss")}");

            //Output as currency
            Console.WriteLine(String.Format("{0:C}", pie));

            //Output as right-aligned (10 spaces), number with 3 decimal places
            Console.WriteLine("{0 ,10:N3}", pie);
        }
    }
}
